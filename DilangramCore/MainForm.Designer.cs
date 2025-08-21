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
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            txtLog = new TextBox();
            grpJobs = new GroupBox();
            btnAddJob = new Button();
            lstApplicationJobs = new ListBox();
            grpUserInfo = new GroupBox();
            grpChatDetail = new GroupBox();
            btnSendMessage = new Button();
            lstChats = new ListBox();
            label1 = new Label();
            txtCodeGenerator = new TextBox();
            btnLockApplication = new Button();
            groupBox1.SuspendLayout();
            grpJobs.SuspendLayout();
            grpUserInfo.SuspendLayout();
            grpChatDetail.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(701, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLog);
            groupBox1.Location = new Point(335, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 225);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Logs";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(6, 18);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(605, 201);
            txtLog.TabIndex = 0;
            // 
            // grpJobs
            // 
            grpJobs.Controls.Add(btnAddJob);
            grpJobs.Controls.Add(lstApplicationJobs);
            grpJobs.Location = new Point(335, 20);
            grpJobs.Name = "grpJobs";
            grpJobs.Size = new Size(345, 196);
            grpJobs.TabIndex = 6;
            grpJobs.TabStop = false;
            grpJobs.Text = "Jobs";
            // 
            // btnAddJob
            // 
            btnAddJob.Location = new Point(18, 157);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(85, 23);
            btnAddJob.TabIndex = 3;
            btnAddJob.Text = "Add Job";
            btnAddJob.UseVisualStyleBackColor = true;
            btnAddJob.Click += btnAddJob_Click;
            // 
            // lstApplicationJobs
            // 
            lstApplicationJobs.FormattingEnabled = true;
            lstApplicationJobs.ItemHeight = 15;
            lstApplicationJobs.Location = new Point(12, 24);
            lstApplicationJobs.Name = "lstApplicationJobs";
            lstApplicationJobs.Size = new Size(320, 124);
            lstApplicationJobs.TabIndex = 2;
            lstApplicationJobs.SelectedIndexChanged += lstApplicationJobs_SelectedIndexChanged;
            // 
            // grpUserInfo
            // 
            grpUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpUserInfo.Controls.Add(grpChatDetail);
            grpUserInfo.Controls.Add(lstChats);
            grpUserInfo.Controls.Add(label1);
            grpUserInfo.Location = new Point(13, 10);
            grpUserInfo.Name = "grpUserInfo";
            grpUserInfo.Size = new Size(283, 431);
            grpUserInfo.TabIndex = 4;
            grpUserInfo.TabStop = false;
            grpUserInfo.Text = "User Name";
            // 
            // grpChatDetail
            // 
            grpChatDetail.Controls.Add(btnSendMessage);
            grpChatDetail.Location = new Point(7, 369);
            grpChatDetail.Name = "grpChatDetail";
            grpChatDetail.Size = new Size(290, 79);
            grpChatDetail.TabIndex = 3;
            grpChatDetail.TabStop = false;
            grpChatDetail.Enter += grpChatDetail_Enter;
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(8, 34);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(138, 23);
            btnSendMessage.TabIndex = 0;
            btnSendMessage.Text = "Scrape Messages";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // lstChats
            // 
            lstChats.FormattingEnabled = true;
            lstChats.ItemHeight = 15;
            lstChats.Location = new Point(7, 48);
            lstChats.Name = "lstChats";
            lstChats.Size = new Size(290, 319);
            lstChats.TabIndex = 1;
            lstChats.SelectedIndexChanged += lstChats_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Chat List :";
            // 
            // txtCodeGenerator
            // 
            txtCodeGenerator.Location = new Point(701, 61);
            txtCodeGenerator.Multiline = true;
            txtCodeGenerator.Name = "txtCodeGenerator";
            txtCodeGenerator.ReadOnly = true;
            txtCodeGenerator.Size = new Size(256, 140);
            txtCodeGenerator.TabIndex = 0;
            // 
            // btnLockApplication
            // 
            btnLockApplication.Location = new Point(789, 32);
            btnLockApplication.Name = "btnLockApplication";
            btnLockApplication.Size = new Size(96, 23);
            btnLockApplication.TabIndex = 7;
            btnLockApplication.Text = "Lock App";
            btnLockApplication.UseVisualStyleBackColor = true;
            btnLockApplication.Click += btnLockApplication_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 475);
            Controls.Add(txtCodeGenerator);
            Controls.Add(btnLockApplication);
            Controls.Add(btnRefresh);
            Controls.Add(groupBox1);
            Controls.Add(grpJobs);
            Controls.Add(grpUserInfo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Dilangram";
            FormClosed += frmMain_FormClosed;
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpJobs.ResumeLayout(false);
            grpUserInfo.ResumeLayout(false);
            grpUserInfo.PerformLayout();
            grpChatDetail.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private GroupBox groupBox1;
        private TextBox txtLog;
        private GroupBox grpJobs;
        private Button btnAddJob;
        private ListBox lstApplicationJobs;
        private GroupBox grpUserInfo;
        private GroupBox grpChatDetail;
        private Button btnSendMessage;
        private ListBox lstChats;
        private Label label1;
        private TextBox txtCodeGenerator;
        private Button btnLockApplication;
    }
}
