
using System.Windows.Forms;

namespace Dilangram.Forms
{
    partial class frmSendMessages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            groupBox1 = new GroupBox();
            rdioSchuldedMessage = new RadioButton();
            grpSchulded = new GroupBox();
            numSchuledTimeMinute = new NumericUpDown();
            label2 = new Label();
            rdioOnceMass = new RadioButton();
            label3 = new Label();
            numTotalMessageCount = new NumericUpDown();
            chkJustMediaMessage = new CheckBox();
            label4 = new Label();
            btnSelectSourceChat = new Button();
            btnSelectTargetChat = new Button();
            label5 = new Label();
            numOffset = new NumericUpDown();
            lblPleaseWait = new Label();
            grpDateRange = new GroupBox();
            chkUseDateRange = new CheckBox();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            lblFromDate = new Label();
            lblToDate = new Label();
            grpMessageFilters = new GroupBox();
            chkTextMessages = new CheckBox();
            chkMediaMessages = new CheckBox();
            chkDocuments = new CheckBox();
            chkPhotos = new CheckBox();
            chkVideos = new CheckBox();
            chkAudio = new CheckBox();
            chkStickers = new CheckBox();
            chkForwardedMessages = new CheckBox();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            lblEstimatedTime = new Label();
            groupBox1.SuspendLayout();
            grpSchulded.SuspendLayout();
            grpDateRange.SuspendLayout();
            grpMessageFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSchuledTimeMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalMessageCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOffset).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 59);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Target Chat :";
            label1.Click += label1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 680);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(350, 680);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(105, 36);
            btnOK.TabIndex = 2;
            btnOK.Text = "&Forward Messages";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdioSchuldedMessage);
            groupBox1.Controls.Add(grpSchulded);
            groupBox1.Controls.Add(rdioOnceMass);
            groupBox1.Location = new Point(14, 490);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 143);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send Type";
            // 
            // rdioSchuldedMessage
            // 
            rdioSchuldedMessage.AutoSize = true;
            rdioSchuldedMessage.Location = new Point(22, 47);
            rdioSchuldedMessage.Name = "rdioSchuldedMessage";
            rdioSchuldedMessage.Size = new Size(116, 19);
            rdioSchuldedMessage.TabIndex = 0;
            rdioSchuldedMessage.Text = "Schulde Message";
            rdioSchuldedMessage.UseVisualStyleBackColor = true;
            rdioSchuldedMessage.CheckedChanged += rdioSchuldedMessage_CheckedChanged;
            // 
            // grpSchulded
            // 
            grpSchulded.Controls.Add(numSchuledTimeMinute);
            grpSchulded.Controls.Add(label2);
            grpSchulded.Enabled = false;
            grpSchulded.Location = new Point(11, 51);
            grpSchulded.Name = "grpSchulded";
            grpSchulded.Size = new Size(237, 61);
            grpSchulded.TabIndex = 1;
            grpSchulded.TabStop = false;
            grpSchulded.Text = "                          ";
            // 
            // numSchuledTimeMinute
            // 
            numSchuledTimeMinute.Location = new Point(60, 22);
            numSchuledTimeMinute.Name = "numSchuledTimeMinute";
            numSchuledTimeMinute.Size = new Size(48, 23);
            numSchuledTimeMinute.TabIndex = 0;
            numSchuledTimeMinute.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 27);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Minute";
            // 
            // rdioOnceMass
            // 
            rdioOnceMass.AutoSize = true;
            rdioOnceMass.Checked = true;
            rdioOnceMass.Location = new Point(23, 22);
            rdioOnceMass.Name = "rdioOnceMass";
            rdioOnceMass.Size = new Size(83, 19);
            rdioOnceMass.TabIndex = 0;
            rdioOnceMass.TabStop = true;
            rdioOnceMass.Text = "Once mass";
            rdioOnceMass.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 142);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 1;
            label3.Text = "Message Count :";
            // 
            // numTotalMessageCount
            // 
            numTotalMessageCount.Location = new Point(113, 138);
            numTotalMessageCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numTotalMessageCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTotalMessageCount.Name = "numTotalMessageCount";
            numTotalMessageCount.Size = new Size(61, 23);
            numTotalMessageCount.TabIndex = 0;
            numTotalMessageCount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // chkJustMediaMessage
            // 
            chkJustMediaMessage.Location = new Point(14, 196);
            chkJustMediaMessage.Name = "chkJustMediaMessage";
            chkJustMediaMessage.Size = new Size(180, 24);
            chkJustMediaMessage.TabIndex = 4;
            chkJustMediaMessage.Text = "Send Just Media Message";
            chkJustMediaMessage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 22);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 1;
            label4.Text = "Source Chat :";
            label4.Click += label1_Click;
            // 
            // btnSelectSourceChat
            // 
            btnSelectSourceChat.Location = new Point(111, 16);
            btnSelectSourceChat.Name = "btnSelectSourceChat";
            btnSelectSourceChat.Size = new Size(167, 25);
            btnSelectSourceChat.TabIndex = 2;
            btnSelectSourceChat.Text = "From : ";
            btnSelectSourceChat.UseVisualStyleBackColor = true;
            btnSelectSourceChat.Click += btnSelectSourceChat_Click;
            // 
            // btnSelectTargetChat
            // 
            btnSelectTargetChat.Location = new Point(111, 54);
            btnSelectTargetChat.Name = "btnSelectTargetChat";
            btnSelectTargetChat.Size = new Size(167, 25);
            btnSelectTargetChat.TabIndex = 2;
            btnSelectTargetChat.Text = "To :";
            btnSelectTargetChat.UseVisualStyleBackColor = true;
            btnSelectTargetChat.Click += btnSelectTargetChat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 110);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 1;
            label5.Text = "Offset Count :";
            // 
            // numOffset
            // 
            numOffset.Location = new Point(113, 106);
            numOffset.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numOffset.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numOffset.Name = "numOffset";
            numOffset.Size = new Size(61, 23);
            numOffset.TabIndex = 0;
            numOffset.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblPleaseWait
            // 
            lblPleaseWait.AutoSize = true;
            lblPleaseWait.Location = new Point(205, 176);
            lblPleaseWait.Name = "lblPleaseWait";
            lblPleaseWait.Size = new Size(73, 15);
            lblPleaseWait.TabIndex = 1;
            lblPleaseWait.Text = "Please Wait..";
            lblPleaseWait.Visible = false;
            lblPleaseWait.Click += label1_Click;
            // 
            // grpDateRange
            // 
            grpDateRange.Controls.Add(chkUseDateRange);
            grpDateRange.Controls.Add(dtpFromDate);
            grpDateRange.Controls.Add(dtpToDate);
            grpDateRange.Controls.Add(lblFromDate);
            grpDateRange.Controls.Add(lblToDate);
            grpDateRange.Location = new Point(14, 180);
            grpDateRange.Name = "grpDateRange";
            grpDateRange.Size = new Size(441, 100);
            grpDateRange.TabIndex = 5;
            grpDateRange.TabStop = false;
            grpDateRange.Text = "Date Range Filter";
            // 
            // chkUseDateRange
            // 
            chkUseDateRange.AutoSize = true;
            chkUseDateRange.Location = new Point(20, 22);
            chkUseDateRange.Name = "chkUseDateRange";
            chkUseDateRange.Size = new Size(136, 19);
            chkUseDateRange.TabIndex = 0;
            chkUseDateRange.Text = "Use date range filter";
            chkUseDateRange.UseVisualStyleBackColor = true;
            chkUseDateRange.CheckedChanged += chkUseDateRange_CheckedChanged;
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFromDate.Enabled = false;
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(80, 50);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(150, 23);
            dtpFromDate.TabIndex = 1;
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpToDate.Enabled = false;
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(265, 50);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(150, 23);
            dtpToDate.TabIndex = 2;
            dtpToDate.Value = DateTime.Now;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new Point(20, 54);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(38, 15);
            lblFromDate.TabIndex = 3;
            lblFromDate.Text = "From:";
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new Point(240, 54);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(22, 15);
            lblToDate.TabIndex = 4;
            lblToDate.Text = "To:";
            // 
            // grpMessageFilters
            // 
            grpMessageFilters.Controls.Add(chkTextMessages);
            grpMessageFilters.Controls.Add(chkMediaMessages);
            grpMessageFilters.Controls.Add(chkDocuments);
            grpMessageFilters.Controls.Add(chkPhotos);
            grpMessageFilters.Controls.Add(chkVideos);
            grpMessageFilters.Controls.Add(chkAudio);
            grpMessageFilters.Controls.Add(chkStickers);
            grpMessageFilters.Controls.Add(chkForwardedMessages);
            grpMessageFilters.Location = new Point(14, 290);
            grpMessageFilters.Name = "grpMessageFilters";
            grpMessageFilters.Size = new Size(441, 120);
            grpMessageFilters.TabIndex = 6;
            grpMessageFilters.TabStop = false;
            grpMessageFilters.Text = "Message Type Filters";
            // 
            // chkTextMessages
            // 
            chkTextMessages.AutoSize = true;
            chkTextMessages.Checked = true;
            chkTextMessages.CheckState = CheckState.Checked;
            chkTextMessages.Location = new Point(20, 25);
            chkTextMessages.Name = "chkTextMessages";
            chkTextMessages.Size = new Size(106, 19);
            chkTextMessages.TabIndex = 0;
            chkTextMessages.Text = "Text Messages";
            chkTextMessages.UseVisualStyleBackColor = true;
            // 
            // chkMediaMessages
            // 
            chkMediaMessages.AutoSize = true;
            chkMediaMessages.Checked = true;
            chkMediaMessages.CheckState = CheckState.Checked;
            chkMediaMessages.Location = new Point(20, 50);
            chkMediaMessages.Name = "chkMediaMessages";
            chkMediaMessages.Size = new Size(114, 19);
            chkMediaMessages.TabIndex = 1;
            chkMediaMessages.Text = "Media Messages";
            chkMediaMessages.UseVisualStyleBackColor = true;
            // 
            // chkDocuments
            // 
            chkDocuments.AutoSize = true;
            chkDocuments.Checked = true;
            chkDocuments.CheckState = CheckState.Checked;
            chkDocuments.Location = new Point(20, 75);
            chkDocuments.Name = "chkDocuments";
            chkDocuments.Size = new Size(89, 19);
            chkDocuments.TabIndex = 2;
            chkDocuments.Text = "Documents";
            chkDocuments.UseVisualStyleBackColor = true;
            // 
            // chkPhotos
            // 
            chkPhotos.AutoSize = true;
            chkPhotos.Checked = true;
            chkPhotos.CheckState = CheckState.Checked;
            chkPhotos.Location = new Point(150, 25);
            chkPhotos.Name = "chkPhotos";
            chkPhotos.Size = new Size(65, 19);
            chkPhotos.TabIndex = 3;
            chkPhotos.Text = "Photos";
            chkPhotos.UseVisualStyleBackColor = true;
            // 
            // chkVideos
            // 
            chkVideos.AutoSize = true;
            chkVideos.Checked = true;
            chkVideos.CheckState = CheckState.Checked;
            chkVideos.Location = new Point(150, 50);
            chkVideos.Name = "chkVideos";
            chkVideos.Size = new Size(61, 19);
            chkVideos.TabIndex = 4;
            chkVideos.Text = "Videos";
            chkVideos.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            chkAudio.AutoSize = true;
            chkAudio.Checked = true;
            chkAudio.CheckState = CheckState.Checked;
            chkAudio.Location = new Point(150, 75);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(58, 19);
            chkAudio.TabIndex = 5;
            chkAudio.Text = "Audio";
            chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkStickers
            // 
            chkStickers.AutoSize = true;
            chkStickers.Checked = true;
            chkStickers.CheckState = CheckState.Checked;
            chkStickers.Location = new Point(250, 25);
            chkStickers.Name = "chkStickers";
            chkStickers.Size = new Size(70, 19);
            chkStickers.TabIndex = 6;
            chkStickers.Text = "Stickers";
            chkStickers.UseVisualStyleBackColor = true;
            // 
            // chkForwardedMessages
            // 
            chkForwardedMessages.AutoSize = true;
            chkForwardedMessages.Checked = true;
            chkForwardedMessages.CheckState = CheckState.Checked;
            chkForwardedMessages.Location = new Point(250, 50);
            chkForwardedMessages.Name = "chkForwardedMessages";
            chkForwardedMessages.Size = new Size(137, 19);
            chkForwardedMessages.TabIndex = 7;
            chkForwardedMessages.Text = "Forwarded Messages";
            chkForwardedMessages.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(14, 420);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(441, 23);
            progressBar.TabIndex = 7;
            progressBar.Visible = false;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(14, 450);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(120, 15);
            lblProgress.TabIndex = 8;
            lblProgress.Text = "Forwarding messages: 0%";
            lblProgress.Visible = false;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.AutoSize = true;
            lblEstimatedTime.Location = new Point(300, 450);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(100, 15);
            lblEstimatedTime.TabIndex = 9;
            lblEstimatedTime.Text = "Estimated: 0 min";
            lblEstimatedTime.Visible = false;
            // 
            // frmSendMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 730);
            ControlBox = false;
            Controls.Add(lblEstimatedTime);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(grpMessageFilters);
            Controls.Add(grpDateRange);
            Controls.Add(chkJustMediaMessage);
            Controls.Add(numOffset);
            Controls.Add(numTotalMessageCount);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnOK);
            Controls.Add(btnSelectTargetChat);
            Controls.Add(btnSelectSourceChat);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(lblPleaseWait);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSendMessages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forward Messages";
            Load += frmSendMessages_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpSchulded.ResumeLayout(false);
            grpSchulded.PerformLayout();
            grpDateRange.ResumeLayout(false);
            grpDateRange.PerformLayout();
            grpMessageFilters.ResumeLayout(false);
            grpMessageFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSchuledTimeMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalMessageCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOffset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private GroupBox groupBox1;
        private RadioButton rdioSchuldedMessage;
        private GroupBox grpSchulded;
        private RadioButton rdioOnceMass;
        private NumericUpDown numSchuledTimeMinute;
        private Label label2;
        private Label label3;
        private NumericUpDown numTotalMessageCount;
        private CheckBox chkJustMediaMessage;
        private Label label4;
        private Button btnSelectSourceChat;
        private Button btnSelectTargetChat;
        private Label label5;
        private NumericUpDown numOffset;
        private Label lblPleaseWait;
        private GroupBox grpDateRange;
        private CheckBox chkUseDateRange;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Label lblFromDate;
        private Label lblToDate;
        private GroupBox grpMessageFilters;
        private CheckBox chkTextMessages;
        private CheckBox chkMediaMessages;
        private CheckBox chkDocuments;
        private CheckBox chkPhotos;
        private CheckBox chkVideos;
        private CheckBox chkAudio;
        private CheckBox chkStickers;
        private CheckBox chkForwardedMessages;
        private ProgressBar progressBar;
        private Label lblProgress;
        private Label lblEstimatedTime;
    }
}