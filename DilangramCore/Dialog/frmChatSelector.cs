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

namespace Dilangram.Dialog
{
    public enum ChatSelectorType
    {
        All,
        CanSend,
        CanRead
    }

    public partial class frmChatSelector : Form
    {
        public string ChatTitle { get; private set; }
        public long ChatId { get; private set; }
        public long ChatUserName { get; private set; }

        public frmChatSelector( long chatId = 0)
        {
            InitializeComponent();

            if (chatId != 0)
            {
                ChatId = chatId;
            }
        }

        private List<string> lstChatsItem = new List<string>();
        private void frmChatSelector_Load(object sender, EventArgs e)
        {
            // Check if ChatList is available
            if (Program.ChatList == null)
            {
                MessageBox.Show("Chat list is not available. Please ensure you are connected to Telegram first.", 
                    "Chat List Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            var chats = Program.ChatList.chats;

            if (chats == null)
            {
                MessageBox.Show("No chats found. Please refresh the chat list.", 
                    "No Chats Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            foreach (var (id, chat) in chats)
            {
                switch (chat)
                {
                    case Chat smallgroup when (smallgroup.flags) != 0 && chat.IsActive:
                        lstChatsItem.Add($"{id}: {smallgroup.title}");
                        break;
                    case Channel channel when (channel.flags & Channel.Flags.broadcast) != 0 && chat.IsActive:
                        lstChatsItem.Add($"{id}: {channel.title} {channel.username}");
                        break;
                    case Channel group when chat.IsActive:
                        lstChatsItem.Add($"{id}: {group.title} {group.username}");
                        break;
                }
            }

            LoadChatItems("");

            if (ChatId == 0)
            {
                if (lstChats.Items.Count > 0)
                    lstChats.SelectedIndex = 0;
            }
            else
            {
                foreach (string st in lstChatsItem)
                {
                    long chatId = long.Parse(st.Substring(0, st.IndexOf(":")));

                    if (ChatId == chatId)
                    {
                        int ix = lstChats.Items.IndexOf(st);
                        lstChats.SelectedIndex = ix;
                    }
                }
            }


        }

        private void LoadChatItems(string filter)
        {
            lstChats.Items.Clear();


            List<string> items = lstChatsItem;
            if (filter.Trim().Length > 0)
            {
                items = lstChatsItem.Where(x => x.Contains(filter)).ToList();
            }

            foreach (string item in items)
            {
                lstChats.Items.Add(item);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lstChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChats.SelectedItem is null) return;

            string selectedItem = lstChats.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selectedItem)) return;

            ChatTitle = selectedItem;
            
            int colonIndex = ChatTitle.IndexOf(":");
            if (colonIndex > 0)
            {
                string chatIdStr = ChatTitle.Substring(0, colonIndex);
                if (long.TryParse(chatIdStr, out long parsedChatId))
                {
                    ChatId = parsedChatId;
                }
            }
        }

        private void lstChats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnOK.PerformClick();
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
            LoadChatItems(txtFilterText.Text);
        }


    }
}
