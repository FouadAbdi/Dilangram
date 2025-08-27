using Dilangram.Dialog;
using Dilangram.Helpers;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Dilangram.Enums;
using TL;
using Dilangram;
using DilangramCore.Model;
using WTelegram;
using Dilangram.Forms;
using static System.Net.Mime.MediaTypeNames;
using DilangramCore.Forms;
using GTranslatorAPI;
using System;

namespace DilangramCore
{
    public partial class MainForm : Form
    {

        public static Client tgClient;

        public MainForm()
        {
            InitializeComponent();

            this.Enabled = false;

            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(s);
        }

        static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return "20833282";
                case "api_hash": return "6d4517a3e6c32f17e5ac2efe026039e2";

                case "phone_number":
                    if (File.Exists("PhoneNumber.txt") == false)
                    {
                        new frmInputTextbox(what).ShowDialog();
                        File.WriteAllText("PhoneNumber.txt", Program.InputTextDialog);
                    }
                    return File.ReadAllText("PhoneNumber.txt");

                case "verification_code":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                case "first_name": return "John";      // if sign-up is required
                case "last_name": return "Doe";        // if sign-up is required

                case "password":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;
                case "session_pathname":
                    return Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar)) ?? AppDomain.CurrentDomain.BaseDirectory, "Dilangram.session");
                default: return null;                  // let WTelegramClient decide the default config
            }
        }



        private async void MainForm_Load(object sender, EventArgs e)
        {
            tgClient = new WTelegram.Client(Config);

            var user = await tgClient.LoginUserIfNeeded();

            //Load Profile
            var users = await tgClient.Users_GetUsers(InputUser.Self);
            var logedInUser = users[0] as User;

            grpUserInfo.Text = $"{logedInUser.first_name} {logedInUser.last_name} ";

            Log($"Welcome {logedInUser.first_name} {logedInUser.last_name}");

            UpdateUi();

            this.Enabled = true;

            await ListenMessages();
        }

        #region Logger
        public void Log(string log)
        {
            Program.Log(log);

            txtLog.Text = string.Join(Environment.NewLine, Program.logs);
        }
        #endregion

        public async void UpdateUi()
        {
            //Load Chat List
            Program.ChatList = await tgClient.Messages_GetAllChats();

            lstChats.Items.Clear();

            foreach (var (id, chat) in Program.ChatList.chats)
            {
                switch (chat)
                {
                    case Chat smallgroup when (smallgroup.flags) != 0 && chat.IsActive:

                        lstChats.Items.Add($"{id}:  Sgroup: {smallgroup.title} {smallgroup.participants_count} members");
                        break;
                    case Channel channel when (channel.flags & Channel.Flags.broadcast) != 0 && chat.IsActive:
                        lstChats.Items.Add($"{id}: Channel {channel.username}: {channel.title}");
                        break;
                    case Channel group when chat.IsActive:
                        lstChats.Items.Add($"{id}: Group {group.username}: {group.title}");
                        break;
                }
            }

            if (lstChats.Items.Count > 0)
                lstChats.SelectedIndex = 0;


            //Load AppJobs
            AppJobHelper.LoadJobs();

            UpdateAppJobs();
        }
        private void UpdateAppJobs()
        {
            lstApplicationJobs.Items.Clear();
            foreach (ChannelJob job in Program.AppJobs)
            {
                job.ChatPeer = Program.GetInputPeerForChatId(job.ChatId);

                lstApplicationJobs.Items.Add($"{job.ChatId}: {job.Title}  {(job.UserName.Length > 2 ? "(@" + job.UserName + ")" : string.Empty)}");
            }
        }



        #region Utility

        //Check if Any element of array exist in text
        private static bool CheckArrayInString(string text, string[] spamWords)
        {
            text = text.ToLower();

            foreach (string st in spamWords)
            {
                if (text.Contains(st.ToLower()))
                    return true;
            }
            return false;
        }
        //Remove Last Line Of String
        private static string RemoveLastLine(string text)
        {
            int ix = Math.Max(text.LastIndexOf("\r\n"), text.LastIndexOf("\n"));

            if (ix > 0)
                text = text.Substring(0, ix);

            return text;
        }

        private static IEnumerable<string> GetAllUrls(string text)
        {
            var rx = new Regex(@"\b(?:https?://)?(?:(?i:[a-z]+\.)+)[^\s,]+\b", RegexOptions.Compiled);

            return rx.Matches(text).Select(x => x.Value);
        }
        private static IEnumerable<string> GetAllMentions(string text)
        {
            var rx = new Regex(@"(?<=^|(?<=[^a-zA-Z0-9-_\.]))@([A-Za-z]+[A-Za-z0-9_]+)+", RegexOptions.Compiled);

            return rx.Matches(text).Select(x => x.Value);
        }

        public static string RemoveAllMention(string text)
        {
            return Regex.Replace(text, @"(?<=^|(?<=[^a-zA-Z0-9-_\.]))@([A-Za-z]+[A-Za-z0-9_]+)+", "");
        }

        #endregion




        #region ListenMessages
        private static long lastMediAGroupId = -1;
        private async Task ListenMessages()
        {
            Log("Listening.....");

            tgClient.OnUpdate += Client_OnUpdate;
        }

        public async static void SendTextToChat(long chatId, string signalString)
        {
            InputPeer sourceChat = Program.GetInputPeerForChatId(chatId);
            await MainForm.tgClient.SendMessageAsync(peer: sourceChat, text: signalString);
        }

        private async Task Client_OnUpdate(IObject arg)
        {
            if (arg is not UpdatesBase updates) return;

            foreach (var update in updates.UpdateList)
            {
                switch (update)
                {
                    case UpdateNewChannelMessage uncm:
                        {
                            TL.Message msg = ((TL.Message)uncm.message);


                            if (msg.reply_markup == null)
                            {
                                long chatId = ((TL.PeerChannel)msg.Peer).ID;

                                //ToDo : Custom Parse Here
                                //CustomMessageParser.Parse(chatId,msg.message.ToString());



                                //Handle All Jobs
                                var jobs = AppJobHelper.GetJobsForChannel(uncm.message.Peer.ID);

                                foreach (ChannelJob job in jobs)
                                {
                                    SourceChannel currentChannel = job.ContentChannels.FirstOrDefault(x => x.ChannelId == uncm.message.Peer.ID);

                                    //Ignore Sended Media In Albums
                                    if (msg.grouped_id == lastMediAGroupId)
                                    {
                                        break;
                                    }

                                    //Ignore Forwarded Message
                                    if (currentChannel.IgnoreForwardedMessages && (msg.fwd_from is not null))
                                    {
                                        break;
                                    }

                                    //Ignore Media Message
                                    if (msg.media is not null && currentChannel.IgnoreMediaMessages)
                                    {
                                        break;
                                    }

                                    //Ignore Message Types
                                    #region IgnoreMessageTypes
                                    if (msg.media is not null)
                                    {
                                        string mediaMessageTypes = msg.media.ToString();
                                        if (currentChannel.IgnoreMessageTypePhoto && msg.media.ToString() == "TL.MessageMediaPhoto")
                                        {
                                            break;
                                        }
                                        if (msg.media.ToString() == "TL.MessageMediaDocument")
                                        {
                                            string mimType = ((TL.Document)((TL.MessageMediaDocument)msg.media).document).mime_type.ToLower();
                                            if (mimType == "audio/ogg" && currentChannel.IgnoreMessageTypeVoice)
                                            {
                                                break;
                                            }

                                            int ix = mimType.IndexOf("/");
                                            string mediaType = mimType.Substring(0, ix);
                                            if (mediaType == "audio" && currentChannel.IgnoreMessageTypeMusic)
                                            {
                                                break;
                                            }

                                            if (mediaType == "video")
                                            {
                                                //Check For Gif
                                                bool isGif = (((TL.Document)((TL.MessageMediaDocument)msg.media).document).attributes).Select(x => x.ToString()).Contains("TL.DocumentAttributeAnimated");

                                                if (currentChannel.IgnoreMessageTypeGif)
                                                {
                                                    break;
                                                }
                                                if (currentChannel.IgnoreMessageTypeVideo)
                                                {
                                                    break;
                                                }
                                            }

                                            if (currentChannel.IgnoreMessageTypeFile)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    #endregion


                                    string text = msg.message.ToString();

                                    Debug.WriteLine(text);

                                    if (currentChannel.DntSendPostLinks)
                                    {
                                        bool hasAnyUrl = GetAllUrls(text).Count() > 0;

                                        if (hasAnyUrl)
                                            break;
                                    }

                                    if (msg.entities is not null)
                                    {
                                        if (currentChannel.DntSendPostHyperLinks)
                                        {
                                            bool hasAnyHyperlink = msg.entities.Any(x => x.ToString() == "TL.MessageEntityTextUrl");

                                            if (hasAnyHyperlink)
                                                break;
                                        }
                                    }


                                    //Remove Text
                                    if (currentChannel.RemoveText)
                                    {
                                        text = string.Empty;
                                    }
                                    else
                                    {

                                        if (currentChannel.DeletePostsWithForeignMentions)
                                        {
                                            string st = Regex.Replace(text, "@" + currentChannel.UserName, "@" + job.UserName, RegexOptions.IgnoreCase);
                                            int mentionCount = GetAllMentions(st).Count();
                                            if (mentionCount > 1)
                                            {
                                                break;
                                            }
                                        }


                                        //Remove All Links
                                        if (currentChannel.RemoveAllLinkInCaption)
                                        {
                                            // Define the regex pattern to match links starting with t.me or https://
                                            string pattern = @"\b(t\.me|https:\/\/)\S+";

                                            // Use Regex.Replace to remove the matched links
                                            text = Regex.Replace(text, pattern, string.Empty);
                                        }



                                        //Implement Auto Translate text Variable
                                        //ToDo : implement user select language in source setting
                                        if (currentChannel.AutoTranslateCaption)
                                        {
                                            if (string.IsNullOrEmpty(text) == false)
                                            {
                                                var translator = new Translator();

                                                string textToTranslate = text.Replace("\r\n", "\n").Replace("\n", ".\n");

                                                textToTranslate = text.Replace("\n", "#$#");


                                                //ToDo : implement reTranslate text if res.TranslatedText equal empty
                                                Translation res = await translator.TranslateAsync(Languages.auto, Languages.ckb, text);


                                                bool hasErrorInTranslate = false;
                                                if (res != null)
                                                {
                                                    if (res.TranslatedText != null)
                                                    {
                                                        text = res.TranslatedText.Replace("#$#", "\n");
                                                    }
                                                    else
                                                    {
                                                        hasErrorInTranslate = true;
                                                    }
                                                }
                                                else
                                                {
                                                    hasErrorInTranslate = true;
                                                }

                                                if (hasErrorInTranslate)
                                                {
                                                    text = "Error In Translate : \n\n" + text;
                                                }

                                            }
                                        }


                                        if (currentChannel.SpamWords is not null)
                                        {
                                            bool isSpam = CheckArrayInString(text, currentChannel.SpamWords);

                                            if (isSpam)
                                                break;
                                        }

                                        if (currentChannel.SpamPostAuthors is not null)
                                        {
                                            if (msg.post_author is not null)
                                            {
                                                bool isPostAuthorsSpam = CheckArrayInString(msg.post_author, currentChannel.SpamPostAuthors);

                                                if (isPostAuthorsSpam)
                                                    break;
                                            }
                                        }



                                        switch (currentChannel.MentionPolicy)
                                        {
                                            case SourceChannelMentions.RemoveAllMentions:
                                                text = RemoveAllMention(text);
                                                break;
                                            case SourceChannelMentions.ReplaceWithJobUserName:
                                                if (currentChannel.UserName.Length > 0)
                                                    text = Regex.Replace(text, "@" + currentChannel.UserName, "@" + job.UserName, RegexOptions.IgnoreCase);
                                                break;
                                        }

                                        if (currentChannel.RemoveFirstLine)
                                        {
                                            string[] lines = text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                                            if (lines.Length > 1)
                                            {
                                                text = string.Join("\r\n", lines.Skip(1).ToArray());
                                            }

                                        }

                                        if (currentChannel.RemoveLastLine)
                                        {
                                            string[] lines = text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                                            if (lines.Length > 1)
                                            {
                                                text = string.Join("\r\n", lines.SkipLast(1).ToArray());
                                            }
                                        }


                                        //Clean Custom Word's
                                        if (currentChannel.CleanCustomWords is not null)
                                        {
                                            foreach (string word in currentChannel.CleanCustomWords)
                                            {
                                                text = Regex.Replace(text, word, "", RegexOptions.IgnoreCase);
                                            }
                                        }



                                        ////automatically replace all consecutive empty lines (regardless of how many there are) with just one empty line
                                        //{
                                        //    // Define the regex pattern to match one or more empty lines
                                        //    string extraNewLinePatternRegex = @"(\r?\n)+";

                                        //    // Replace all consecutive empty lines with a single empty line
                                        //    text = Regex.Replace(text, extraNewLinePatternRegex, Environment.NewLine);
                                        //}



                                        //Append And Prepend Text
                                        if (currentChannel.PrependText is not null)
                                            text = currentChannel.PrependText + text;
                                        if (currentChannel.AppendText is not null)
                                            text += currentChannel.AppendText;
                                    }


                                    //Check if that album
                                    if (msg.grouped_id == 0)
                                    {
                                        if (msg.media == null)
                                        {
                                            if (currentChannel.RemoveText is false)
                                                await tgClient.SendMessageAsync(peer: job.ChatPeer, text: text);
                                        }
                                        else
                                        {
                                            await tgClient.SendMessageAsync(peer: job.ChatPeer, text: text, media: msg.media.ToInputMedia());
                                        }
                                    }
                                    else
                                    {
                                        if (currentChannel.DntSendAlbums is false)
                                        {
                                            lastMediAGroupId = msg.grouped_id;
                                            InputPeer fromChat = Program.GetInputPeerForChatId(currentChannel.ChannelId);


                                            // Fetch the album messages from the source channel
                                            var history = await tgClient.Messages_GetHistory(fromChat);

                                            var albumMessages = history.Messages
                                                .OfType<TL.Message>()
                                                .Where(m => m.grouped_id != null && m.grouped_id== lastMediAGroupId) // Filter for grouped messages (albums)
                                                .ToList();

                                            // Extract message IDs of the album
                                            int[] messageIds = albumMessages.Select(m => ((int)m.id)).ToArray();

                                            
                                            if (messageIds.Length > 0)
                                            {

                                                List<InputMedia> albumGroupMedia = albumMessages
                                                    .Select(m => m.media.ToInputMedia())
                                                    .ToList();

                                                await tgClient.SendAlbumAsync(peer: job.ChatPeer, medias: albumGroupMedia, caption: text);
                                            }

                                        }
                                    }
                                    Log($"{job.Title} has send message from {currentChannel.UserName}");
                                }

                            }
                            break;

                        }
                }
            }
        }


        #endregion




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateUi();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            tgClient?.Dispose();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            new frmJobEditor().ShowDialog();
            UpdateAppJobs();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            new frmSendMessages().ShowDialog();
        }

        private void lstApplicationJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstApplicationJobs.SelectedItem is null) return;

            string selected = lstApplicationJobs.SelectedItem.ToString();
            long jobId = long.Parse(selected.Substring(0, selected.IndexOf(":")));

            ChannelJob job = AppJobHelper.GetJobByChannlId(jobId);

            frmJobEditor jobEditor = new frmJobEditor(job);
            jobEditor.ShowDialog();

            UpdateAppJobs();
        }

        private void lstChats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstChats_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] splited = lstChats.SelectedItem.ToString().Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            string chanellId = splited[0].Trim();

            txtCodeGenerator.Text = "// Sniff Channel : " + splited[1] + Environment.NewLine + @"if(uncm.message.Peer.ID==" + chanellId + ")" + Environment.NewLine + "{" + Environment.NewLine + Environment.NewLine + "}";
        }

        private void btnLockApplication_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUnlock unlock = new frmUnlock();
            unlock.ShowDialog();
        }

        private void grpChatDetail_Enter(object sender, EventArgs e)
        {

        }




    }
}
