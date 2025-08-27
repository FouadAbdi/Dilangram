namespace DilangramCore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblUserInfo = new Label();
            lblTitle = new Label();
            panelSidebar = new Panel();
            btnJobs = new Button();
            btnSendMessage = new Button();
            btnChannels = new Button();
            btnConnect = new Button();
            lblConnectionStatus = new Label();
            panelMain = new Panel();
            tabControl = new TabControl();
            tabChats = new TabPage();
            lstChats = new ListBox();
            label1 = new Label();
            tabJobs = new TabPage();
            btnAddJob = new Button();
            lstApplicationJobs = new ListBox();
            tabLogs = new TabPage();
            txtLog = new TextBox();
            btnRefresh = new Button();
            txtCodeGenerator = new TextBox();
            btnLockApplication = new Button();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            tabControl.SuspendLayout();
            tabChats.SuspendLayout();
            tabJobs.SuspendLayout();
            tabLogs.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(54, 57, 63);
            panelHeader.Controls.Add(lblUserInfo);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 10F);
            lblUserInfo.ForeColor = Color.White;
            lblUserInfo.Location = new Point(1000, 25);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(96, 19);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Not logged in";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dilangram - Telegram Client";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(47, 49, 54);
            panelSidebar.Controls.Add(btnJobs);
            panelSidebar.Controls.Add(btnSendMessage);
            panelSidebar.Controls.Add(btnChannels);
            panelSidebar.Controls.Add(btnConnect);
            panelSidebar.Controls.Add(lblConnectionStatus);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 70);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 560);
            panelSidebar.TabIndex = 1;
            // 
            // btnJobs
            // 
            btnJobs.BackColor = Color.FromArgb(88, 101, 242);
            btnJobs.FlatAppearance.BorderSize = 0;
            btnJobs.FlatStyle = FlatStyle.Flat;
            btnJobs.Font = new Font("Segoe UI", 11F);
            btnJobs.ForeColor = Color.White;
            btnJobs.Location = new Point(20, 280);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(210, 50);
            btnJobs.TabIndex = 4;
            btnJobs.Text = "📋 Manage Jobs";
            btnJobs.UseVisualStyleBackColor = false;
            btnJobs.Click += btnJobs_Click;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.FromArgb(88, 101, 242);
            btnSendMessage.FlatAppearance.BorderSize = 0;
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.Font = new Font("Segoe UI", 11F);
            btnSendMessage.ForeColor = Color.White;
            btnSendMessage.Location = new Point(20, 220);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(210, 50);
            btnSendMessage.TabIndex = 3;
            btnSendMessage.Text = "� Clone Chat";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // btnChannels
            // 
            btnChannels.BackColor = Color.FromArgb(88, 101, 242);
            btnChannels.FlatAppearance.BorderSize = 0;
            btnChannels.FlatStyle = FlatStyle.Flat;
            btnChannels.Font = new Font("Segoe UI", 11F);
            btnChannels.ForeColor = Color.White;
            btnChannels.Location = new Point(20, 160);
            btnChannels.Name = "btnChannels";
            btnChannels.Size = new Size(210, 50);
            btnChannels.TabIndex = 2;
            btnChannels.Text = "📺 Manage Channels";
            btnChannels.UseVisualStyleBackColor = false;
            btnChannels.Click += btnChannels_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(67, 181, 129);
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(20, 80);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(210, 50);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "🔌 Connect to Telegram";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Font = new Font("Segoe UI", 10F);
            lblConnectionStatus.ForeColor = Color.FromArgb(220, 221, 222);
            lblConnectionStatus.Location = new Point(20, 30);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(108, 19);
            lblConnectionStatus.TabIndex = 0;
            lblConnectionStatus.Text = "🔴 Disconnected";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(64, 68, 75);
            panelMain.Controls.Add(tabControl);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(txtCodeGenerator);
            panelMain.Controls.Add(btnLockApplication);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 70);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(950, 560);
            panelMain.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabChats);
            tabControl.Controls.Add(tabJobs);
            tabControl.Controls.Add(tabLogs);
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(20, 20);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(700, 520);
            tabControl.TabIndex = 8;
            // 
            // tabChats
            // 
            tabChats.BackColor = Color.FromArgb(54, 57, 63);
            tabChats.Controls.Add(lstChats);
            tabChats.Controls.Add(label1);
            tabChats.ForeColor = Color.White;
            tabChats.Location = new Point(4, 28);
            tabChats.Name = "tabChats";
            tabChats.Padding = new Padding(3);
            tabChats.Size = new Size(692, 488);
            tabChats.TabIndex = 0;
            tabChats.Text = "📺 Chats";
            // 
            // lstChats
            // 
            lstChats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstChats.BackColor = Color.FromArgb(32, 34, 37);
            lstChats.BorderStyle = BorderStyle.FixedSingle;
            lstChats.Font = new Font("Segoe UI", 10F);
            lstChats.ForeColor = Color.White;
            lstChats.FormattingEnabled = true;
            lstChats.ItemHeight = 17;
            lstChats.Location = new Point(15, 50);
            lstChats.Name = "lstChats";
            lstChats.Size = new Size(660, 410);
            lstChats.TabIndex = 2;
            lstChats.SelectedIndexChanged += lstChats_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "Chat List :";
            // 
            // tabJobs
            // 
            tabJobs.BackColor = Color.FromArgb(54, 57, 63);
            tabJobs.Controls.Add(btnAddJob);
            tabJobs.Controls.Add(lstApplicationJobs);
            tabJobs.ForeColor = Color.White;
            tabJobs.Location = new Point(4, 28);
            tabJobs.Name = "tabJobs";
            tabJobs.Padding = new Padding(3);
            tabJobs.Size = new Size(692, 488);
            tabJobs.TabIndex = 1;
            tabJobs.Text = "📋 Jobs";
            // 
            // btnAddJob
            // 
            btnAddJob.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddJob.BackColor = Color.FromArgb(67, 181, 129);
            btnAddJob.FlatAppearance.BorderSize = 0;
            btnAddJob.FlatStyle = FlatStyle.Flat;
            btnAddJob.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddJob.ForeColor = Color.White;
            btnAddJob.Location = new Point(15, 440);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(120, 35);
            btnAddJob.TabIndex = 4;
            btnAddJob.Text = "➕ Add Job";
            btnAddJob.UseVisualStyleBackColor = false;
            btnAddJob.Click += btnAddJob_Click;
            // 
            // lstApplicationJobs
            // 
            lstApplicationJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstApplicationJobs.BackColor = Color.FromArgb(32, 34, 37);
            lstApplicationJobs.BorderStyle = BorderStyle.FixedSingle;
            lstApplicationJobs.Font = new Font("Segoe UI", 10F);
            lstApplicationJobs.ForeColor = Color.White;
            lstApplicationJobs.FormattingEnabled = true;
            lstApplicationJobs.ItemHeight = 17;
            lstApplicationJobs.Location = new Point(15, 15);
            lstApplicationJobs.Name = "lstApplicationJobs";
            lstApplicationJobs.Size = new Size(660, 410);
            lstApplicationJobs.TabIndex = 3;
            lstApplicationJobs.SelectedIndexChanged += lstApplicationJobs_SelectedIndexChanged;
            // 
            // tabLogs
            // 
            tabLogs.BackColor = Color.FromArgb(54, 57, 63);
            tabLogs.Controls.Add(txtLog);
            tabLogs.ForeColor = Color.White;
            tabLogs.Location = new Point(4, 28);
            tabLogs.Name = "tabLogs";
            tabLogs.Padding = new Padding(3);
            tabLogs.Size = new Size(692, 488);
            tabLogs.TabIndex = 2;
            tabLogs.Text = "📜 Logs";
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.BackColor = Color.FromArgb(32, 34, 37);
            txtLog.BorderStyle = BorderStyle.FixedSingle;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.ForeColor = Color.White;
            txtLog.Location = new Point(15, 15);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(660, 460);
            txtLog.TabIndex = 1;
            txtLog.Text = "Welcome to Dilangram!\r\nClick 'Connect to Telegram' to get started...";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(88, 101, 242);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(740, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 35);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtCodeGenerator
            // 
            txtCodeGenerator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCodeGenerator.BackColor = Color.FromArgb(32, 34, 37);
            txtCodeGenerator.BorderStyle = BorderStyle.FixedSingle;
            txtCodeGenerator.Font = new Font("Consolas", 9F);
            txtCodeGenerator.ForeColor = Color.White;
            txtCodeGenerator.Location = new Point(740, 70);
            txtCodeGenerator.Multiline = true;
            txtCodeGenerator.Name = "txtCodeGenerator";
            txtCodeGenerator.ReadOnly = true;
            txtCodeGenerator.ScrollBars = ScrollBars.Vertical;
            txtCodeGenerator.Size = new Size(190, 140);
            txtCodeGenerator.TabIndex = 0;
            // 
            // btnLockApplication
            // 
            btnLockApplication.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLockApplication.BackColor = Color.FromArgb(240, 71, 71);
            btnLockApplication.FlatAppearance.BorderSize = 0;
            btnLockApplication.FlatStyle = FlatStyle.Flat;
            btnLockApplication.Font = new Font("Segoe UI", 10F);
            btnLockApplication.ForeColor = Color.White;
            btnLockApplication.Location = new Point(840, 20);
            btnLockApplication.Name = "btnLockApplication";
            btnLockApplication.Size = new Size(90, 35);
            btnLockApplication.TabIndex = 7;
            btnLockApplication.Text = "🔒 Lock App";
            btnLockApplication.UseVisualStyleBackColor = false;
            btnLockApplication.Click += btnLockApplication_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(47, 49, 54);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 630);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1200, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.ForeColor = Color.White;
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 17);
            statusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1200, 652);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Controls.Add(statusStrip);
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dilangram - Telegram Client";
            FormClosed += frmMain_FormClosed;
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            tabControl.ResumeLayout(false);
            tabChats.ResumeLayout(false);
            tabChats.PerformLayout();
            tabJobs.ResumeLayout(false);
            tabLogs.ResumeLayout(false);
            tabLogs.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblUserInfo;
        private Label lblTitle;
        private Panel panelSidebar;
        private Button btnJobs;
        private Button btnChannels;
        private Button btnConnect;
        private Label lblConnectionStatus;
        private Panel panelMain;
        private TabControl tabControl;
        private TabPage tabChats;
        private TabPage tabJobs;
        private TabPage tabLogs;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private Button btnRefresh;
        private TextBox txtLog;
        private Button btnAddJob;
        private ListBox lstApplicationJobs;
        private ListBox lstChats;
        private Label label1;
        private TextBox txtCodeGenerator;
        private Button btnLockApplication;
        private Button btnSendMessage;
    }
}
