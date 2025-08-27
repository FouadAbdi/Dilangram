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
        public static Client? tgClient;
        private User? currentUser;
        private bool isConnected = false;

        public MainForm()
        {
            InitializeComponent();
            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(s);
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Initially disable buttons until connected
            btnChannels.Enabled = false;
            btnSendMessage.Enabled = false;
            btnJobs.Enabled = false;
            btnRefresh.Enabled = false;
            
            // Setup initial status
            UpdateConnectionStatus(false);
            LogMessage("🚀 Dilangram started. Ready to connect to Telegram.");
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(LogMessage), message);
                return;
            }
            
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string logEntry = $"[{timestamp}] {message}";
            
            if (txtLog.Text.Length > 0)
                txtLog.AppendText(Environment.NewLine + logEntry);
            else
                txtLog.Text = logEntry;
                
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
            
            // Update status bar
            statusLabel.Text = message.Replace("🚀", "").Replace("✅", "").Replace("❌", "").Replace("🔌", "").Trim();
        }

        private void UpdateConnectionStatus(bool connected)
        {
            isConnected = connected;
            
            if (connected)
            {
                lblConnectionStatus.Text = "🟢 Connected";
                lblConnectionStatus.ForeColor = Color.LightGreen;
                btnConnect.Text = "🔌 Disconnect";
                btnConnect.BackColor = Color.FromArgb(240, 71, 71);
                
                // Enable other buttons
                btnChannels.Enabled = true;
                btnSendMessage.Enabled = true;
                btnJobs.Enabled = true;
                btnRefresh.Enabled = true;
            }
            else
            {
                lblConnectionStatus.Text = "🔴 Disconnected";
                lblConnectionStatus.ForeColor = Color.LightCoral;
                btnConnect.Text = "🔌 Connect to Telegram";
                btnConnect.BackColor = Color.FromArgb(67, 181, 129);
                
                // Disable other buttons
                btnChannels.Enabled = false;
                btnSendMessage.Enabled = false;
                btnJobs.Enabled = false;
                btnRefresh.Enabled = false;
                
                lblUserInfo.Text = "Not logged in";
            }
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

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                await ConnectToTelegram();
            }
            else
            {
                DisconnectFromTelegram();
            }
        }

        private async Task ConnectToTelegram()
        {
            try
            {
                LogMessage("🔌 Connecting to Telegram...");
                btnConnect.Enabled = false;
                
                tgClient = new WTelegram.Client(Config);
                var user = await tgClient.LoginUserIfNeeded();
                
                if (user != null)
                {
                    currentUser = user;
                    LogMessage($"✅ Successfully connected as: {user.first_name} {user.last_name}");
                    lblUserInfo.Text = $"👤 {user.first_name} {user.last_name}";
                    
                    UpdateConnectionStatus(true);
                    
                    // Load user profile details
                    await LoadUserProfile();
                    
                    // Update UI with chat data
                    UpdateUi();
                    
                    // Start listening for messages
                    await ListenMessages();
                }
                else
                {
                    LogMessage("❌ Failed to connect to Telegram");
                    UpdateConnectionStatus(false);
                }
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Connection error: {ex.Message}");
                UpdateConnectionStatus(false);
            }
            finally
            {
                btnConnect.Enabled = true;
            }
        }

        private void DisconnectFromTelegram()
        {
            try
            {
                LogMessage("🔌 Disconnecting from Telegram...");
                
                tgClient?.Dispose();
                tgClient = null;
                currentUser = null;
                
                UpdateConnectionStatus(false);
                LogMessage("✅ Disconnected from Telegram");
                
                // Clear UI data
                lstChats.Items.Clear();
                lstApplicationJobs.Items.Clear();
                txtCodeGenerator.Clear();
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Disconnect error: {ex.Message}");
            }
        }

        private async Task LoadUserProfile()
        {
            try
            {
                LogMessage("📄 Loading user profile...");
                
                var users = await tgClient.Users_GetUsers(InputUser.Self);
                var loggedInUser = users[0] as User;
                
                if (loggedInUser != null)
                {
                    LogMessage($"📄 Profile loaded: ID {loggedInUser.id}, Username: @{loggedInUser.username ?? "N/A"}");
                }
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Error loading profile: {ex.Message}");
            }
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("📺 Opening Channel Management...");
            // Switch to chats tab
            tabControl.SelectedTab = tabChats;
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("📋 Opening Job Management...");
            // Switch to jobs tab
            tabControl.SelectedTab = tabJobs;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            LogMessage("🚀 Application loaded successfully");
            LogMessage("ℹ️  Click 'Connect to Telegram' to start using the application");
        }

        #region Logger
        public void Log(string log)
        {
            Program.Log(log);
            LogMessage(log);
        }
        #endregion

        public async void UpdateUi()
        {
            if (!isConnected || tgClient == null) return;
            
            try
            {
                LogMessage("🔄 Updating UI data...");
                
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
                
                LogMessage($"✅ UI updated - {lstChats.Items.Count} chats, {lstApplicationJobs.Items.Count} jobs");
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Error updating UI: {ex.Message}");
            }
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
            LogMessage("👂 Starting message listener...");
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
                                                .Where(m => m.grouped_id != null && m.grouped_id == lastMediAGroupId) // Filter for grouped messages (albums)
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
            LogMessage("🔄 Refreshing data...");
            UpdateUi();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogMessage("🔄 Shutting down...");
            tgClient?.Dispose();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("➕ Opening job editor...");
            new frmJobEditor().ShowDialog();
            UpdateAppJobs();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("� Opening chat cloner...");
            new frmSendMessages().ShowDialog();
        }

        private void lstApplicationJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstApplicationJobs.SelectedItem is null) return;

            string selected = lstApplicationJobs.SelectedItem.ToString();
            long jobId = long.Parse(selected.Substring(0, selected.IndexOf(":")));

            ChannelJob job = AppJobHelper.GetJobByChannlId(jobId);

            LogMessage($"📝 Editing job: {job.Title}");
            frmJobEditor jobEditor = new frmJobEditor(job);
            jobEditor.ShowDialog();

            UpdateAppJobs();
        }

        private void lstChats_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstChats.SelectedItem == null) return;
            
            string[] splited = lstChats.SelectedItem.ToString().Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            string channelId = splited[0].Trim();

            txtCodeGenerator.Text = "// Sniff Channel : " + splited[1] + Environment.NewLine + @"if(uncm.message.Peer.ID==" + channelId + ")" + Environment.NewLine + "{" + Environment.NewLine + Environment.NewLine + "}";
            
            LogMessage($"📺 Selected chat: {splited[1].Trim()}");
        }

        private void btnLockApplication_Click(object sender, EventArgs e)
        {
            LogMessage("🔒 Locking application...");
            this.Hide();

            frmUnlock unlock = new frmUnlock();
            unlock.ShowDialog();
            
            if (unlock.DialogResult == DialogResult.OK)
            {
                this.Show();
                LogMessage("🔓 Application unlocked");
            }
        }
    }
}
