using Dilangram.Dialog;
using DilangramCore;
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
    public partial class frmSendMessages : Form
    {
        public frmSendMessages()
        {
            InitializeComponent();

        }

        private void frmSendMessages_Load(object sender, EventArgs e)
        {

        }



        private async void btnOK_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            lblPleaseWait.Visible = true;


            InputPeer sourceChat = Program.GetInputPeerForChatId(sourceChatId);
            InputPeer targetChat = Program.GetInputPeerForChatId(targetChatId);

            long lastMediAGroupId = 0;


            int offset = (int)numOffset.Value;
            int totalMessagesCount = (int)numTotalMessageCount.Value;
            int takeCount = 50;


            for (int j = totalMessagesCount; j >= 0; j -= takeCount)
            {
                List<Task> scraperTasks = new List<Task>();

                int limitCount = takeCount;
                if (takeCount > j)
                    limitCount = j;



                var history = await MainForm.tgClient.Messages_GetHistory(sourceChat, add_offset: offset, limit: limitCount);



                MessageBase pm = null;
                for (int i = history.Messages.Length - 1; i >= 0; i--)
                {
                    pm = history.Messages[i];

                    if (pm.GetType() == typeof(TL.Message))
                    {
                        TL.Message msg = pm as TL.Message;

                        string text =  msg.message.ToString();




                        //Check if that album
                        if (msg.grouped_id == 0)
                        {
                            if (msg.media == null)
                            {
                                if (chkJustMediaMessage.Checked is false)
                                {
                                    await MainForm.tgClient.SendMessageAsync(peer: targetChat, text: text);
                                }
                            }
                            else
                                await MainForm.tgClient.SendMessageAsync(peer: targetChat, text: text, media: msg.media.ToInputMedia(), entities: msg.entities);
                        }
                        else
                        {
                            if (msg.grouped_id != lastMediAGroupId)
                            {
                                lastMediAGroupId = msg.grouped_id;
                                var hst = await MainForm.tgClient.Messages_GetHistory(targetChat);
                                List<InputMedia> albumGroupMedia = history.Messages.OfType<TL.Message>().Where(x => x.grouped_id == msg.grouped_id)
                                    .Select(m => m.media.ToInputMedia())
                                    .ToList();

                                await MainForm.tgClient.SendAlbumAsync(peer: targetChat, medias: albumGroupMedia, caption: text);
                            }
                        }
                    }
                    else
                    {

                    }
                }





                offset += limitCount;
            }




            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdioSchuldedMessage_CheckedChanged(object sender, EventArgs e)
        {
            grpSchulded.Enabled = rdioSchuldedMessage.Checked;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        long sourceChatId = 0;
        long targetChatId = 0;
        private void btnSelectSourceChat_Click(object sender, EventArgs e)
        {
            frmChatSelector frmChatSelector = new frmChatSelector(sourceChatId);
            frmChatSelector.ShowDialog();
            sourceChatId = frmChatSelector.ChatId;

            if (sourceChatId > 0)
            {
                btnSelectSourceChat.Text = "From : " + sourceChatId;
            }
        }

        private void btnSelectTargetChat_Click(object sender, EventArgs e)
        {
            frmChatSelector frmChatSelector = new frmChatSelector(targetChatId);
            frmChatSelector.ShowDialog();
            targetChatId = frmChatSelector.ChatId;

            if (targetChatId > 0)
            {
                btnSelectTargetChat.Text = "To : " + targetChatId;
            }
        }



    }
}
