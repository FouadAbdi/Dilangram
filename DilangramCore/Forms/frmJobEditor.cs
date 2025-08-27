using DilangramCore.Model;
using Dilangram.Dialog;
using Dilangram.Helpers;
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
    public partial class frmJobEditor : Form
    {
        private ChannelJob channelJob;
        private long selectedTargetChatId;
        public frmJobEditor(ChannelJob _channelJob = null)
        {
            InitializeComponent();

            if (_channelJob == null)
            {
                channelJob = new ChannelJob();
                channelJob.ContentChannels = new List<SourceChannel>();
            }
            else
            {
                channelJob = _channelJob;
                selectedTargetChatId = _channelJob.ChatId;

                UpdateUi();
            }
        }


        private void UpdateUi()
        {
            txtTitle.Text = channelJob.Title;
            txtChatId.Text = channelJob.ChatId.ToString();
            txtUserName.Text = channelJob.UserName;

            UpdateContentChannels();
        }
        private void UpdateContentChannels()
        {
            lstJobContentChannel.Items.Clear();
            foreach (SourceChannel sc in channelJob.ContentChannels)
            {
                lstJobContentChannel.Items.Add($"{sc.ChannelId}: {sc.UserName}");
            }
        }


        private void frmJobEditor_Load(object sender, EventArgs e)
        {

        }


        private void btnSelectTargetChannel_Click(object sender, EventArgs e)
        {
            frmChatSelector selector = new frmChatSelector(channelJob.ChatId);
            if (selector.ShowDialog() == DialogResult.OK)
            {
                txtChatId.Text = selector.ChatTitle;
                selectedTargetChatId = selector.ChatId;
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            channelJob.Title = txtTitle.Text;
            channelJob.UserName = txtUserName.Text;

            //Check if chatid==-1 Add to jobs
            if (channelJob.ChatId == 0)//Add
            {
                channelJob.ChatId = selectedTargetChatId;
                AppJobHelper.AddJob(channelJob);
                Program.Log($"\"{channelJob.Title}\" was added successfully.");
            }
            else//edit
            {
                channelJob.ChatId = selectedTargetChatId;
                AppJobHelper.SaveJobs();
                Program.Log($"\"{channelJob.Title}\" was edited successfully.");
            }

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure To Delete?", "Delete Job", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if(AppJobHelper.GetJobByChannlId(selectedTargetChatId) is not null)
                {
                    AppJobHelper.RemoveJob(channelJob);
                    AppJobHelper.SaveJobs();

                    Program.Log($"\"{channelJob.Title}\" was removed successfully.");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAddContentChannel_Click(object sender, EventArgs e)
        {
            new frmContentChannel(channelJob).ShowDialog();

            UpdateContentChannels();
        }

        private void lstJobContentChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstJobContentChannel.SelectedItem is null) return;
            
            string selected = lstJobContentChannel.SelectedItem.ToString();
            long chatId = long.Parse(selected.Substring(0, selected.IndexOf(":")));

            SourceChannel sc = channelJob.ContentChannels.FirstOrDefault(x => x.ChannelId == chatId);
            if (sc is not null)
            {
                new frmContentChannel(channelJob, sc).ShowDialog();
                UpdateContentChannels();
            }

        }






    }
}
