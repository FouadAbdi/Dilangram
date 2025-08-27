
namespace Dilangram.Forms
{
    partial class frmContentChannel
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
            btnCancel = new Button();
            btnOk = new Button();
            btnDelete = new Button();
            txtChannelId = new TextBox();
            label3 = new Label();
            btnSelectSourceChannel = new Button();
            txtUserName = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rdioMentionDoNothing = new RadioButton();
            rdioMentionReplaceWithJobUserName = new RadioButton();
            rdioMentionRemoveAllMentions = new RadioButton();
            groupBox2 = new GroupBox();
            chkDntSendPostHyperLinks = new CheckBox();
            chkDntSendPostLinks = new CheckBox();
            chkDntSendAlbums = new CheckBox();
            grpTextPolicy = new GroupBox();
            label5 = new Label();
            txtAppend = new TextBox();
            label4 = new Label();
            txtPrepend = new TextBox();
            groupBox5 = new GroupBox();
            lblCleanCustomWords = new Label();
            txtCleanCustomWords = new TextBox();
            chkRemoveFirstLine = new CheckBox();
            chkRemoveLastLine = new CheckBox();
            groupBox4 = new GroupBox();
            lblSpamPostAuthors = new Label();
            txtSpamPostAuthors = new TextBox();
            groupBox3 = new GroupBox();
            lblSpamWords = new Label();
            txtSpamWords = new TextBox();
            label1 = new Label();
            chkRemoveText = new CheckBox();
            chkIgnoreMediaMessages = new CheckBox();
            chkDeletePostsWithForeignMentions = new CheckBox();
            chkIgnoreForwardedMessages = new CheckBox();
            grpIgnoreMessagesTypes = new GroupBox();
            chkIgnoreMessageTypeVoiceMessages = new CheckBox();
            chkIgnoreMessageTypeGifs = new CheckBox();
            chkIgnoreMessageTypeFiles = new CheckBox();
            chkIgnoreMessageTypeMusics = new CheckBox();
            chkIgnoreMessageTypeVideos = new CheckBox();
            chkIgnoreMessageTypePhotos = new CheckBox();
            chkRemoveAllLinkInCaption = new CheckBox();
            chkAutoTranslateCaption = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpTextPolicy.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            grpIgnoreMessagesTypes.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(758, 486);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(899, 486);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 23);
            btnOk.TabIndex = 7;
            btnOk.Text = "&OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(828, 486);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtChannelId
            // 
            txtChannelId.Location = new Point(88, 18);
            txtChannelId.Name = "txtChannelId";
            txtChannelId.ReadOnly = true;
            txtChannelId.Size = new Size(175, 23);
            txtChannelId.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 10;
            label3.Text = "ChannelId : ";
            // 
            // btnSelectSourceChannel
            // 
            btnSelectSourceChannel.Location = new Point(269, 12);
            btnSelectSourceChannel.Name = "btnSelectSourceChannel";
            btnSelectSourceChannel.Size = new Size(155, 33);
            btnSelectSourceChannel.TabIndex = 9;
            btnSelectSourceChannel.Text = "Select Source Channel";
            btnSelectSourceChannel.UseVisualStyleBackColor = true;
            btnSelectSourceChannel.Click += btnSelectSourceChannel_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(505, 18);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(152, 23);
            txtUserName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 21);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 12;
            label2.Text = "User Name : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdioMentionDoNothing);
            groupBox1.Controls.Add(rdioMentionReplaceWithJobUserName);
            groupBox1.Controls.Add(rdioMentionRemoveAllMentions);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 104);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mentions Policy";
            // 
            // rdioMentionDoNothing
            // 
            rdioMentionDoNothing.AutoSize = true;
            rdioMentionDoNothing.Location = new Point(19, 72);
            rdioMentionDoNothing.Name = "rdioMentionDoNothing";
            rdioMentionDoNothing.Size = new Size(87, 19);
            rdioMentionDoNothing.TabIndex = 0;
            rdioMentionDoNothing.Text = "Do Nothing";
            rdioMentionDoNothing.UseVisualStyleBackColor = true;
            // 
            // rdioMentionReplaceWithJobUserName
            // 
            rdioMentionReplaceWithJobUserName.AutoSize = true;
            rdioMentionReplaceWithJobUserName.Checked = true;
            rdioMentionReplaceWithJobUserName.Location = new Point(19, 47);
            rdioMentionReplaceWithJobUserName.Name = "rdioMentionReplaceWithJobUserName";
            rdioMentionReplaceWithJobUserName.Size = new Size(173, 19);
            rdioMentionReplaceWithJobUserName.TabIndex = 0;
            rdioMentionReplaceWithJobUserName.TabStop = true;
            rdioMentionReplaceWithJobUserName.Text = "Replace With Job UserName";
            rdioMentionReplaceWithJobUserName.UseVisualStyleBackColor = true;
            // 
            // rdioMentionRemoveAllMentions
            // 
            rdioMentionRemoveAllMentions.AutoSize = true;
            rdioMentionRemoveAllMentions.Location = new Point(19, 22);
            rdioMentionRemoveAllMentions.Name = "rdioMentionRemoveAllMentions";
            rdioMentionRemoveAllMentions.Size = new Size(141, 19);
            rdioMentionRemoveAllMentions.TabIndex = 0;
            rdioMentionRemoveAllMentions.Text = "Remove All Mention's";
            rdioMentionRemoveAllMentions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkDntSendPostHyperLinks);
            groupBox2.Controls.Add(chkDntSendPostLinks);
            groupBox2.Location = new Point(300, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 104);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Link Policy";
            // 
            // chkDntSendPostHyperLinks
            // 
            chkDntSendPostHyperLinks.AutoSize = true;
            chkDntSendPostHyperLinks.Checked = true;
            chkDntSendPostHyperLinks.CheckState = CheckState.Checked;
            chkDntSendPostHyperLinks.Location = new Point(12, 48);
            chkDntSendPostHyperLinks.Name = "chkDntSendPostHyperLinks";
            chkDntSendPostHyperLinks.Size = new Size(221, 19);
            chkDntSendPostHyperLinks.TabIndex = 0;
            chkDntSendPostHyperLinks.Text = "Don't Send Posts that have Hyperlink";
            chkDntSendPostHyperLinks.UseVisualStyleBackColor = true;
            // 
            // chkDntSendPostLinks
            // 
            chkDntSendPostLinks.AutoSize = true;
            chkDntSendPostLinks.Checked = true;
            chkDntSendPostLinks.CheckState = CheckState.Checked;
            chkDntSendPostLinks.Location = new Point(12, 23);
            chkDntSendPostLinks.Name = "chkDntSendPostLinks";
            chkDntSendPostLinks.Size = new Size(194, 19);
            chkDntSendPostLinks.TabIndex = 0;
            chkDntSendPostLinks.Text = "Don't Send Posts that have links";
            chkDntSendPostLinks.UseVisualStyleBackColor = true;
            // 
            // chkDntSendAlbums
            // 
            chkDntSendAlbums.AutoSize = true;
            chkDntSendAlbums.Location = new Point(590, 453);
            chkDntSendAlbums.Name = "chkDntSendAlbums";
            chkDntSendAlbums.Size = new Size(131, 19);
            chkDntSendAlbums.TabIndex = 16;
            chkDntSendAlbums.Text = "Don't Send Album's";
            chkDntSendAlbums.UseVisualStyleBackColor = true;
            // 
            // grpTextPolicy
            // 
            grpTextPolicy.Controls.Add(label5);
            grpTextPolicy.Controls.Add(txtAppend);
            grpTextPolicy.Controls.Add(label4);
            grpTextPolicy.Controls.Add(txtPrepend);
            grpTextPolicy.Controls.Add(groupBox5);
            grpTextPolicy.Controls.Add(chkRemoveFirstLine);
            grpTextPolicy.Controls.Add(chkRemoveLastLine);
            grpTextPolicy.Controls.Add(groupBox4);
            grpTextPolicy.Controls.Add(groupBox3);
            grpTextPolicy.Controls.Add(label1);
            grpTextPolicy.Location = new Point(12, 190);
            grpTextPolicy.Name = "grpTextPolicy";
            grpTextPolicy.Size = new Size(934, 242);
            grpTextPolicy.TabIndex = 19;
            grpTextPolicy.TabStop = false;
            grpTextPolicy.Text = "Text Policy :                                 ";
            grpTextPolicy.Enter += grpTextPolicy_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 131);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 23;
            label5.Text = "Append Text :";
            // 
            // txtAppend
            // 
            txtAppend.Location = new Point(657, 151);
            txtAppend.Multiline = true;
            txtAppend.Name = "txtAppend";
            txtAppend.Size = new Size(271, 64);
            txtAppend.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 20);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 23;
            label4.Text = "Prepend Text :";
            // 
            // txtPrepend
            // 
            txtPrepend.Location = new Point(657, 41);
            txtPrepend.Multiline = true;
            txtPrepend.Name = "txtPrepend";
            txtPrepend.Size = new Size(271, 64);
            txtPrepend.TabIndex = 21;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblCleanCustomWords);
            groupBox5.Controls.Add(txtCleanCustomWords);
            groupBox5.Location = new Point(434, 41);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(208, 170);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Clean Custom Word's";
            // 
            // lblCleanCustomWords
            // 
            lblCleanCustomWords.Location = new Point(6, 105);
            lblCleanCustomWords.Name = "lblCleanCustomWords";
            lblCleanCustomWords.Size = new Size(196, 62);
            lblCleanCustomWords.TabIndex = 20;
            // 
            // txtCleanCustomWords
            // 
            txtCleanCustomWords.Location = new Point(6, 22);
            txtCleanCustomWords.Multiline = true;
            txtCleanCustomWords.Name = "txtCleanCustomWords";
            txtCleanCustomWords.Size = new Size(196, 80);
            txtCleanCustomWords.TabIndex = 19;
            txtCleanCustomWords.TextChanged += txtCleanCustomWords_TextChanged;
            // 
            // chkRemoveFirstLine
            // 
            chkRemoveFirstLine.AutoSize = true;
            chkRemoveFirstLine.Location = new Point(19, 218);
            chkRemoveFirstLine.Name = "chkRemoveFirstLine";
            chkRemoveFirstLine.Size = new Size(119, 19);
            chkRemoveFirstLine.TabIndex = 16;
            chkRemoveFirstLine.Text = "Remove First Line";
            chkRemoveFirstLine.UseVisualStyleBackColor = true;
            // 
            // chkRemoveLastLine
            // 
            chkRemoveLastLine.AutoSize = true;
            chkRemoveLastLine.Location = new Point(147, 218);
            chkRemoveLastLine.Name = "chkRemoveLastLine";
            chkRemoveLastLine.Size = new Size(118, 19);
            chkRemoveLastLine.TabIndex = 16;
            chkRemoveLastLine.Text = "Remove Last Line";
            chkRemoveLastLine.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSpamPostAuthors);
            groupBox4.Controls.Add(txtSpamPostAuthors);
            groupBox4.Location = new Point(220, 41);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(208, 170);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Spam Post Author's";
            // 
            // lblSpamPostAuthors
            // 
            lblSpamPostAuthors.Location = new Point(6, 105);
            lblSpamPostAuthors.Name = "lblSpamPostAuthors";
            lblSpamPostAuthors.Size = new Size(196, 62);
            lblSpamPostAuthors.TabIndex = 20;
            // 
            // txtSpamPostAuthors
            // 
            txtSpamPostAuthors.Location = new Point(6, 22);
            txtSpamPostAuthors.Multiline = true;
            txtSpamPostAuthors.Name = "txtSpamPostAuthors";
            txtSpamPostAuthors.Size = new Size(196, 80);
            txtSpamPostAuthors.TabIndex = 19;
            txtSpamPostAuthors.TextChanged += txtSpamPostAuthors_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSpamWords);
            groupBox3.Controls.Add(txtSpamWords);
            groupBox3.Location = new Point(6, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(208, 170);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Spam Word's";
            // 
            // lblSpamWords
            // 
            lblSpamWords.Location = new Point(6, 105);
            lblSpamWords.Name = "lblSpamWords";
            lblSpamWords.Size = new Size(196, 62);
            lblSpamWords.TabIndex = 20;
            // 
            // txtSpamWords
            // 
            txtSpamWords.Location = new Point(6, 22);
            txtSpamWords.Multiline = true;
            txtSpamWords.Name = "txtSpamWords";
            txtSpamWords.Size = new Size(196, 80);
            txtSpamWords.TabIndex = 19;
            txtSpamWords.TextChanged += txtSpamWords_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 19);
            label1.Name = "label1";
            label1.Size = new Size(241, 15);
            label1.TabIndex = 19;
            label1.Text = "Use , Seprator For Diffrent Between Elements";
            // 
            // chkRemoveText
            // 
            chkRemoveText.AutoSize = true;
            chkRemoveText.Location = new Point(95, 190);
            chkRemoveText.Name = "chkRemoveText";
            chkRemoveText.Size = new Size(93, 19);
            chkRemoveText.TabIndex = 20;
            chkRemoveText.Text = "Remove Text";
            chkRemoveText.UseVisualStyleBackColor = true;
            chkRemoveText.CheckedChanged += chkRemoveText_CheckedChanged;
            // 
            // chkIgnoreMediaMessages
            // 
            chkIgnoreMediaMessages.AutoSize = true;
            chkIgnoreMediaMessages.Location = new Point(434, 453);
            chkIgnoreMediaMessages.Name = "chkIgnoreMediaMessages";
            chkIgnoreMediaMessages.Size = new Size(150, 19);
            chkIgnoreMediaMessages.TabIndex = 16;
            chkIgnoreMediaMessages.Text = "Ignore Media Messages";
            chkIgnoreMediaMessages.UseVisualStyleBackColor = true;
            chkIgnoreMediaMessages.CheckedChanged += chkIgnoreMediaMessages_CheckedChanged;
            // 
            // chkDeletePostsWithForeignMentions
            // 
            chkDeletePostsWithForeignMentions.AutoSize = true;
            chkDeletePostsWithForeignMentions.Checked = true;
            chkDeletePostsWithForeignMentions.CheckState = CheckState.Checked;
            chkDeletePostsWithForeignMentions.Location = new Point(12, 453);
            chkDeletePostsWithForeignMentions.Name = "chkDeletePostsWithForeignMentions";
            chkDeletePostsWithForeignMentions.Size = new Size(214, 19);
            chkDeletePostsWithForeignMentions.TabIndex = 16;
            chkDeletePostsWithForeignMentions.Text = "Delete Posts With Foreign Mentions";
            chkDeletePostsWithForeignMentions.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreForwardedMessages
            // 
            chkIgnoreForwardedMessages.AutoSize = true;
            chkIgnoreForwardedMessages.Checked = true;
            chkIgnoreForwardedMessages.CheckState = CheckState.Checked;
            chkIgnoreForwardedMessages.Location = new Point(245, 453);
            chkIgnoreForwardedMessages.Name = "chkIgnoreForwardedMessages";
            chkIgnoreForwardedMessages.Size = new Size(173, 19);
            chkIgnoreForwardedMessages.TabIndex = 16;
            chkIgnoreForwardedMessages.Text = "Ignore Forwarded Messages";
            chkIgnoreForwardedMessages.UseVisualStyleBackColor = true;
            // 
            // grpIgnoreMessagesTypes
            // 
            grpIgnoreMessagesTypes.Controls.Add(chkIgnoreMessageTypeVoiceMessages);
            grpIgnoreMessagesTypes.Controls.Add(chkIgnoreMessageTypeGifs);
            grpIgnoreMessagesTypes.Controls.Add(chkIgnoreMessageTypeFiles);
            grpIgnoreMessagesTypes.Controls.Add(chkIgnoreMessageTypeMusics);
            grpIgnoreMessagesTypes.Controls.Add(chkIgnoreMessageTypeVideos);
            grpIgnoreMessagesTypes.Controls.Add(chkIgnoreMessageTypePhotos);
            grpIgnoreMessagesTypes.Location = new Point(559, 70);
            grpIgnoreMessagesTypes.Name = "grpIgnoreMessagesTypes";
            grpIgnoreMessagesTypes.Size = new Size(334, 104);
            grpIgnoreMessagesTypes.TabIndex = 21;
            grpIgnoreMessagesTypes.TabStop = false;
            grpIgnoreMessagesTypes.Text = "Ignore Message Types :";
            // 
            // chkIgnoreMessageTypeVoiceMessages
            // 
            chkIgnoreMessageTypeVoiceMessages.AutoSize = true;
            chkIgnoreMessageTypeVoiceMessages.Location = new Point(171, 58);
            chkIgnoreMessageTypeVoiceMessages.Name = "chkIgnoreMessageTypeVoiceMessages";
            chkIgnoreMessageTypeVoiceMessages.Size = new Size(111, 19);
            chkIgnoreMessageTypeVoiceMessages.TabIndex = 1;
            chkIgnoreMessageTypeVoiceMessages.Text = "Voice Message's";
            chkIgnoreMessageTypeVoiceMessages.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeGifs
            // 
            chkIgnoreMessageTypeGifs.AutoSize = true;
            chkIgnoreMessageTypeGifs.Location = new Point(29, 58);
            chkIgnoreMessageTypeGifs.Name = "chkIgnoreMessageTypeGifs";
            chkIgnoreMessageTypeGifs.Size = new Size(49, 19);
            chkIgnoreMessageTypeGifs.TabIndex = 2;
            chkIgnoreMessageTypeGifs.Text = "Gif's";
            chkIgnoreMessageTypeGifs.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeFiles
            // 
            chkIgnoreMessageTypeFiles.AutoSize = true;
            chkIgnoreMessageTypeFiles.Location = new Point(101, 58);
            chkIgnoreMessageTypeFiles.Name = "chkIgnoreMessageTypeFiles";
            chkIgnoreMessageTypeFiles.Size = new Size(52, 19);
            chkIgnoreMessageTypeFiles.TabIndex = 2;
            chkIgnoreMessageTypeFiles.Text = "File's";
            chkIgnoreMessageTypeFiles.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeMusics
            // 
            chkIgnoreMessageTypeMusics.AutoSize = true;
            chkIgnoreMessageTypeMusics.Location = new Point(171, 22);
            chkIgnoreMessageTypeMusics.Name = "chkIgnoreMessageTypeMusics";
            chkIgnoreMessageTypeMusics.Size = new Size(66, 19);
            chkIgnoreMessageTypeMusics.TabIndex = 3;
            chkIgnoreMessageTypeMusics.Text = "Music's";
            chkIgnoreMessageTypeMusics.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeVideos
            // 
            chkIgnoreMessageTypeVideos.AutoSize = true;
            chkIgnoreMessageTypeVideos.Location = new Point(101, 23);
            chkIgnoreMessageTypeVideos.Name = "chkIgnoreMessageTypeVideos";
            chkIgnoreMessageTypeVideos.Size = new Size(64, 19);
            chkIgnoreMessageTypeVideos.TabIndex = 4;
            chkIgnoreMessageTypeVideos.Text = "Video's";
            chkIgnoreMessageTypeVideos.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypePhotos
            // 
            chkIgnoreMessageTypePhotos.AutoSize = true;
            chkIgnoreMessageTypePhotos.Location = new Point(29, 23);
            chkIgnoreMessageTypePhotos.Name = "chkIgnoreMessageTypePhotos";
            chkIgnoreMessageTypePhotos.Size = new Size(66, 19);
            chkIgnoreMessageTypePhotos.TabIndex = 5;
            chkIgnoreMessageTypePhotos.Text = "Photo's";
            chkIgnoreMessageTypePhotos.UseVisualStyleBackColor = true;
            // 
            // chkRemoveAllLinkInCaption
            // 
            chkRemoveAllLinkInCaption.AutoSize = true;
            chkRemoveAllLinkInCaption.Location = new Point(12, 478);
            chkRemoveAllLinkInCaption.Name = "chkRemoveAllLinkInCaption";
            chkRemoveAllLinkInCaption.Size = new Size(169, 19);
            chkRemoveAllLinkInCaption.TabIndex = 16;
            chkRemoveAllLinkInCaption.Text = "Remove All Link In Caption";
            chkRemoveAllLinkInCaption.UseVisualStyleBackColor = true;
            // 
            // chkAutoTranslateCaption
            // 
            chkAutoTranslateCaption.AutoSize = true;
            chkAutoTranslateCaption.Location = new Point(245, 478);
            chkAutoTranslateCaption.Name = "chkAutoTranslateCaption";
            chkAutoTranslateCaption.Size = new Size(147, 19);
            chkAutoTranslateCaption.TabIndex = 16;
            chkAutoTranslateCaption.Text = "Auto Translate Caption";
            chkAutoTranslateCaption.UseVisualStyleBackColor = true;
            // 
            // frmContentChannel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 521);
            ControlBox = false;
            Controls.Add(grpIgnoreMessagesTypes);
            Controls.Add(chkRemoveText);
            Controls.Add(grpTextPolicy);
            Controls.Add(chkAutoTranslateCaption);
            Controls.Add(chkRemoveAllLinkInCaption);
            Controls.Add(chkDeletePostsWithForeignMentions);
            Controls.Add(chkIgnoreForwardedMessages);
            Controls.Add(chkIgnoreMediaMessages);
            Controls.Add(chkDntSendAlbums);
            Controls.Add(groupBox1);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtChannelId);
            Controls.Add(label3);
            Controls.Add(btnSelectSourceChannel);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmContentChannel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Content Editor";
            Load += frmContentChannel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpTextPolicy.ResumeLayout(false);
            grpTextPolicy.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grpIgnoreMessagesTypes.ResumeLayout(false);
            grpIgnoreMessagesTypes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtChannelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectSourceChannel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdioMentionDoNothing;
        private System.Windows.Forms.RadioButton rdioMentionReplaceWithJobUserName;
        private System.Windows.Forms.RadioButton rdioMentionRemoveAllMentions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRemoveLastLine;
        private System.Windows.Forms.CheckBox chkDntSendPostHyperLinks;
        private System.Windows.Forms.CheckBox chkDntSendPostLinks;
        private System.Windows.Forms.CheckBox chkDntSendAlbums;
        private System.Windows.Forms.GroupBox grpTextPolicy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCleanCustomWords;
        private System.Windows.Forms.TextBox txtCleanCustomWords;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSpamPostAuthors;
        private System.Windows.Forms.TextBox txtSpamPostAuthors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSpamWords;
        private System.Windows.Forms.TextBox txtSpamWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRemoveText;
        private System.Windows.Forms.CheckBox chkIgnoreMediaMessages;
        private System.Windows.Forms.CheckBox chkDeletePostsWithForeignMentions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrepend;
        private System.Windows.Forms.CheckBox chkIgnoreForwardedMessages;
        private System.Windows.Forms.GroupBox grpIgnoreMessagesTypes;
        private System.Windows.Forms.CheckBox chkIgnoreMessageTypeVoiceMessages;
        private System.Windows.Forms.CheckBox chkIgnoreMessageTypeFiles;
        private System.Windows.Forms.CheckBox chkIgnoreMessageTypeMusics;
        private System.Windows.Forms.CheckBox chkIgnoreMessageTypeVideos;
        private System.Windows.Forms.CheckBox chkIgnoreMessageTypePhotos;
        private System.Windows.Forms.CheckBox chkIgnoreMessageTypeGifs;
        private CheckBox chkRemoveFirstLine;
        private CheckBox chkRemoveAllLinkInCaption;
        private CheckBox chkAutoTranslateCaption;
    }
}