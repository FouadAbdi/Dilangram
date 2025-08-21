using ChannelSniffer.Model;
using Dilangram.Dialog;
using Dilangram.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;

namespace Dilangram.Forms
{
    public partial class frmContentChannel : Form
    {
        private SourceChannel sourceChannel;
        private ChannelJob job;
        long selectedChannelId;
        public frmContentChannel(ChannelJob channelJob, SourceChannel sc = null)
        {
            InitializeComponent();

            job = channelJob;

            if (sc == null)
            {
                sourceChannel = new SourceChannel();
            }
            else
            {
                sourceChannel = sc;

                selectedChannelId = sourceChannel.ChannelId;
                txtUserName.Text = sourceChannel.UserName;
                txtChannelId.Text = sourceChannel.ChannelId.ToString();

                switch (sourceChannel.MentionPolicy)
                {
                    case Enums.SourceChannelMentions.RemoveAllMentions:
                        rdioMentionRemoveAllMentions.Checked = true;
                        break;
                    case Enums.SourceChannelMentions.DoNothing:
                        rdioMentionDoNothing.Checked = true;
                        break;
                    case Enums.SourceChannelMentions.ReplaceWithJobUserName:
                        rdioMentionReplaceWithJobUserName.Checked = true;
                        break;
                }

                chkIgnoreForwardedMessages.Checked = sourceChannel.IgnoreForwardedMessages;
                chkDntSendPostLinks.Checked = sourceChannel.DntSendPostLinks;
                chkDntSendPostHyperLinks.Checked = sourceChannel.DntSendPostHyperLinks;
                chkDntSendAlbums.Checked = sourceChannel.DntSendAlbums;
                chkRemoveText.Checked = sourceChannel.RemoveText;
                chkRemoveLastLine.Checked = sourceChannel.RemoveLastLine;
                chkIgnoreMediaMessages.Checked = sourceChannel.IgnoreMediaMessages;
                chkDeletePostsWithForeignMentions.Checked = sourceChannel.DeletePostsWithForeignMentions;
                txtAppend.Text = sourceChannel.AppendText;
                txtPrepend.Text = sourceChannel.PrependText;


                chkIgnoreMessageTypePhotos.Checked = sourceChannel.IgnoreMessageTypePhoto;
                chkIgnoreMessageTypeVideos.Checked = sourceChannel.IgnoreMessageTypeVideo;
                chkIgnoreMessageTypeMusics.Checked = sourceChannel.IgnoreMessageTypeMusic;
                chkIgnoreMessageTypeVoiceMessages.Checked = sourceChannel.IgnoreMessageTypeVoice;
                chkIgnoreMessageTypeFiles.Checked = sourceChannel.IgnoreMessageTypeFile;
                chkIgnoreMessageTypeGifs.Checked = sourceChannel.IgnoreMessageTypeGif;

                if (sourceChannel.SpamWords is not null)
                    txtSpamWords.Text = string.Join(",", sourceChannel.SpamWords);
                if (sourceChannel.SpamPostAuthors is not null)
                    txtSpamPostAuthors.Text = string.Join(",", sourceChannel.SpamPostAuthors);
                if (sourceChannel.CleanCustomWords is not null)
                    txtCleanCustomWords.Text = string.Join(",", sourceChannel.CleanCustomWords);

            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure To Delete?", "Delete Job", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (job.ContentChannels.Contains(sourceChannel))
                {
                    job.ContentChannels.Remove(sourceChannel);
                    AppJobHelper.SaveJobs();

                    Program.Log($"source channel was removed from \"{job.Title}\"");
                }
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            sourceChannel.UserName = txtUserName.Text;

            //Mention Policy
            if (rdioMentionReplaceWithJobUserName.Checked) sourceChannel.MentionPolicy = Enums.SourceChannelMentions.ReplaceWithJobUserName;
            if (rdioMentionRemoveAllMentions.Checked) sourceChannel.MentionPolicy = Enums.SourceChannelMentions.RemoveAllMentions;
            if (rdioMentionDoNothing.Checked) sourceChannel.MentionPolicy = Enums.SourceChannelMentions.DoNothing;

            //Link Policy
            sourceChannel.DntSendPostLinks = chkDntSendPostLinks.Checked;
            sourceChannel.DntSendPostHyperLinks = chkDntSendPostHyperLinks.Checked;

            sourceChannel.DntSendAlbums = chkDntSendAlbums.Checked;

            sourceChannel.IgnoreForwardedMessages = chkIgnoreForwardedMessages.Checked;
            sourceChannel.IgnoreMediaMessages = chkIgnoreMediaMessages.Checked;
            sourceChannel.RemoveText = chkRemoveText.Checked;
            sourceChannel.DeletePostsWithForeignMentions = chkDeletePostsWithForeignMentions.Checked;

            sourceChannel.AppendText = txtAppend.Text;
            sourceChannel.PrependText = txtPrepend.Text;
            sourceChannel.RemoveLastLine = chkRemoveLastLine.Checked;


            sourceChannel.IgnoreMessageTypePhoto = chkIgnoreMessageTypePhotos.Checked;
            sourceChannel.IgnoreMessageTypeVideo = chkIgnoreMessageTypeVideos.Checked;
            sourceChannel.IgnoreMessageTypeMusic = chkIgnoreMessageTypeMusics.Checked;
            sourceChannel.IgnoreMessageTypeVoice = chkIgnoreMessageTypeVoiceMessages.Checked;
            sourceChannel.IgnoreMessageTypeGif = chkIgnoreMessageTypeGifs.Checked;
            sourceChannel.IgnoreMessageTypeFile = chkIgnoreMessageTypeFiles.Checked;


            //Check if sourceChannel.ChannelId==-1 Add to jobs
            if (sourceChannel.ChannelId == -1)//Add
            {
                sourceChannel.ChannelId = selectedChannelId;

                job.ContentChannels.Add(sourceChannel);

                Program.Log($"source channel was  added successfully to \"{job.Title}\"");
            }
            else//edit
            {
                sourceChannel.ChannelId = selectedChannelId;
                AppJobHelper.SaveJobs();
                Program.Log($"source channel was edited successfully.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSelectSourceChannel_Click(object sender, EventArgs e)
        {
            frmChatSelector selector = new frmChatSelector(selectedChannelId);
            if (selector.ShowDialog() == DialogResult.OK)
            {
                txtChannelId.Text = selector.ChatTitle;
                selectedChannelId = selector.ChatId;

                if (txtUserName.Text.Trim().Length == 0)
                {
                    try
                    {
                        txtUserName.Text = ((Channel)Program.ChatList.chats[selectedChannelId]).username;
                    }
                    catch { }

                }
            }
        }




        private void txtSpamWords_TextChanged(object sender, EventArgs e)
        {
            sourceChannel.SpamWords = txtSpamWords.Text.Split(new[] { ",", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            lblSpamWords.Text = string.Join(" ✅ ", sourceChannel.SpamWords);
        }

        private void txtSpamPostAuthors_TextChanged(object sender, EventArgs e)
        {
            sourceChannel.SpamPostAuthors = txtSpamPostAuthors.Text.Split(new[] { ",", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            lblSpamPostAuthors.Text = string.Join(" ✅ ", sourceChannel.SpamPostAuthors);
        }

        private void txtCleanCustomWords_TextChanged(object sender, EventArgs e)
        {
            sourceChannel.CleanCustomWords = txtCleanCustomWords.Text.Split(new[] { ",", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            lblCleanCustomWords.Text = string.Join(" ✅ ", sourceChannel.CleanCustomWords);
        }

        private void frmContentChannel_Load(object sender, EventArgs e)
        {

        }

        private void chkRemoveText_CheckedChanged(object sender, EventArgs e)
        {
            grpTextPolicy.Enabled = !chkRemoveText.Checked;
        }

        private void grpTextPolicy_Enter(object sender, EventArgs e)
        {

        }

        private void chkIgnoreMediaMessages_CheckedChanged(object sender, EventArgs e)
        {
            grpIgnoreMessagesTypes.Enabled = !chkIgnoreMediaMessages.Enabled;
        }


    }
}
