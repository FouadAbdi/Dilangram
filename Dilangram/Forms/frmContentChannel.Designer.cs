
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtChannelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectSourceChannel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioMentionDoNothing = new System.Windows.Forms.RadioButton();
            this.rdioMentionReplaceWithJobUserName = new System.Windows.Forms.RadioButton();
            this.rdioMentionRemoveAllMentions = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDntSendPostHyperLinks = new System.Windows.Forms.CheckBox();
            this.chkDntSendPostLinks = new System.Windows.Forms.CheckBox();
            this.chkDntSendAlbums = new System.Windows.Forms.CheckBox();
            this.grpTextPolicy = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrepend = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCleanCustomWords = new System.Windows.Forms.Label();
            this.txtCleanCustomWords = new System.Windows.Forms.TextBox();
            this.chkRemoveLastLine = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSpamPostAuthors = new System.Windows.Forms.Label();
            this.txtSpamPostAuthors = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSpamWords = new System.Windows.Forms.Label();
            this.txtSpamWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRemoveText = new System.Windows.Forms.CheckBox();
            this.chkIgnoreMediaMessages = new System.Windows.Forms.CheckBox();
            this.chkDeletePostsWithForeignMentions = new System.Windows.Forms.CheckBox();
            this.chkIgnoreForwardedMessages = new System.Windows.Forms.CheckBox();
            this.grpIgnoreMessagesTypes = new System.Windows.Forms.GroupBox();
            this.chkIgnoreMessageTypeVoiceMessages = new System.Windows.Forms.CheckBox();
            this.chkIgnoreMessageTypeGifs = new System.Windows.Forms.CheckBox();
            this.chkIgnoreMessageTypeFiles = new System.Windows.Forms.CheckBox();
            this.chkIgnoreMessageTypeMusics = new System.Windows.Forms.CheckBox();
            this.chkIgnoreMessageTypeVideos = new System.Windows.Forms.CheckBox();
            this.chkIgnoreMessageTypePhotos = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpTextPolicy.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpIgnoreMessagesTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(758, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(899, 486);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(65, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(828, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtChannelId
            // 
            this.txtChannelId.Location = new System.Drawing.Point(88, 18);
            this.txtChannelId.Name = "txtChannelId";
            this.txtChannelId.ReadOnly = true;
            this.txtChannelId.Size = new System.Drawing.Size(175, 23);
            this.txtChannelId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ChannelId : ";
            // 
            // btnSelectSourceChannel
            // 
            this.btnSelectSourceChannel.Location = new System.Drawing.Point(269, 12);
            this.btnSelectSourceChannel.Name = "btnSelectSourceChannel";
            this.btnSelectSourceChannel.Size = new System.Drawing.Size(155, 33);
            this.btnSelectSourceChannel.TabIndex = 9;
            this.btnSelectSourceChannel.Text = "Select Source Channel";
            this.btnSelectSourceChannel.UseVisualStyleBackColor = true;
            this.btnSelectSourceChannel.Click += new System.EventHandler(this.btnSelectSourceChannel_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(505, 18);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 23);
            this.txtUserName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioMentionDoNothing);
            this.groupBox1.Controls.Add(this.rdioMentionReplaceWithJobUserName);
            this.groupBox1.Controls.Add(this.rdioMentionRemoveAllMentions);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 104);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mentions Policy";
            // 
            // rdioMentionDoNothing
            // 
            this.rdioMentionDoNothing.AutoSize = true;
            this.rdioMentionDoNothing.Location = new System.Drawing.Point(19, 72);
            this.rdioMentionDoNothing.Name = "rdioMentionDoNothing";
            this.rdioMentionDoNothing.Size = new System.Drawing.Size(87, 19);
            this.rdioMentionDoNothing.TabIndex = 0;
            this.rdioMentionDoNothing.Text = "Do Nothing";
            this.rdioMentionDoNothing.UseVisualStyleBackColor = true;
            // 
            // rdioMentionReplaceWithJobUserName
            // 
            this.rdioMentionReplaceWithJobUserName.AutoSize = true;
            this.rdioMentionReplaceWithJobUserName.Checked = true;
            this.rdioMentionReplaceWithJobUserName.Location = new System.Drawing.Point(19, 47);
            this.rdioMentionReplaceWithJobUserName.Name = "rdioMentionReplaceWithJobUserName";
            this.rdioMentionReplaceWithJobUserName.Size = new System.Drawing.Size(173, 19);
            this.rdioMentionReplaceWithJobUserName.TabIndex = 0;
            this.rdioMentionReplaceWithJobUserName.TabStop = true;
            this.rdioMentionReplaceWithJobUserName.Text = "Replace With Job UserName";
            this.rdioMentionReplaceWithJobUserName.UseVisualStyleBackColor = true;
            // 
            // rdioMentionRemoveAllMentions
            // 
            this.rdioMentionRemoveAllMentions.AutoSize = true;
            this.rdioMentionRemoveAllMentions.Location = new System.Drawing.Point(19, 22);
            this.rdioMentionRemoveAllMentions.Name = "rdioMentionRemoveAllMentions";
            this.rdioMentionRemoveAllMentions.Size = new System.Drawing.Size(141, 19);
            this.rdioMentionRemoveAllMentions.TabIndex = 0;
            this.rdioMentionRemoveAllMentions.Text = "Remove All Mention\'s";
            this.rdioMentionRemoveAllMentions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDntSendPostHyperLinks);
            this.groupBox2.Controls.Add(this.chkDntSendPostLinks);
            this.groupBox2.Location = new System.Drawing.Point(300, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 104);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Link Policy";
            // 
            // chkDntSendPostHyperLinks
            // 
            this.chkDntSendPostHyperLinks.AutoSize = true;
            this.chkDntSendPostHyperLinks.Checked = true;
            this.chkDntSendPostHyperLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDntSendPostHyperLinks.Location = new System.Drawing.Point(12, 48);
            this.chkDntSendPostHyperLinks.Name = "chkDntSendPostHyperLinks";
            this.chkDntSendPostHyperLinks.Size = new System.Drawing.Size(221, 19);
            this.chkDntSendPostHyperLinks.TabIndex = 0;
            this.chkDntSendPostHyperLinks.Text = "Don\'t Send Posts that have Hyperlink";
            this.chkDntSendPostHyperLinks.UseVisualStyleBackColor = true;
            // 
            // chkDntSendPostLinks
            // 
            this.chkDntSendPostLinks.AutoSize = true;
            this.chkDntSendPostLinks.Checked = true;
            this.chkDntSendPostLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDntSendPostLinks.Location = new System.Drawing.Point(12, 23);
            this.chkDntSendPostLinks.Name = "chkDntSendPostLinks";
            this.chkDntSendPostLinks.Size = new System.Drawing.Size(194, 19);
            this.chkDntSendPostLinks.TabIndex = 0;
            this.chkDntSendPostLinks.Text = "Don\'t Send Posts that have links";
            this.chkDntSendPostLinks.UseVisualStyleBackColor = true;
            // 
            // chkDntSendAlbums
            // 
            this.chkDntSendAlbums.AutoSize = true;
            this.chkDntSendAlbums.Location = new System.Drawing.Point(596, 489);
            this.chkDntSendAlbums.Name = "chkDntSendAlbums";
            this.chkDntSendAlbums.Size = new System.Drawing.Size(131, 19);
            this.chkDntSendAlbums.TabIndex = 16;
            this.chkDntSendAlbums.Text = "Don\'t Send Album\'s";
            this.chkDntSendAlbums.UseVisualStyleBackColor = true;
            // 
            // grpTextPolicy
            // 
            this.grpTextPolicy.Controls.Add(this.label5);
            this.grpTextPolicy.Controls.Add(this.txtAppend);
            this.grpTextPolicy.Controls.Add(this.label4);
            this.grpTextPolicy.Controls.Add(this.txtPrepend);
            this.grpTextPolicy.Controls.Add(this.groupBox5);
            this.grpTextPolicy.Controls.Add(this.chkRemoveLastLine);
            this.grpTextPolicy.Controls.Add(this.groupBox4);
            this.grpTextPolicy.Controls.Add(this.groupBox3);
            this.grpTextPolicy.Controls.Add(this.label1);
            this.grpTextPolicy.Location = new System.Drawing.Point(12, 190);
            this.grpTextPolicy.Name = "grpTextPolicy";
            this.grpTextPolicy.Size = new System.Drawing.Size(934, 242);
            this.grpTextPolicy.TabIndex = 19;
            this.grpTextPolicy.TabStop = false;
            this.grpTextPolicy.Text = "Text Policy :                                 ";
            this.grpTextPolicy.Enter += new System.EventHandler(this.grpTextPolicy_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Append Text :";
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(657, 151);
            this.txtAppend.Multiline = true;
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.Size = new System.Drawing.Size(271, 64);
            this.txtAppend.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Prepend Text :";
            // 
            // txtPrepend
            // 
            this.txtPrepend.Location = new System.Drawing.Point(657, 41);
            this.txtPrepend.Multiline = true;
            this.txtPrepend.Name = "txtPrepend";
            this.txtPrepend.Size = new System.Drawing.Size(271, 64);
            this.txtPrepend.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCleanCustomWords);
            this.groupBox5.Controls.Add(this.txtCleanCustomWords);
            this.groupBox5.Location = new System.Drawing.Point(434, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 170);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clean Custom Word\'s";
            // 
            // lblCleanCustomWords
            // 
            this.lblCleanCustomWords.Location = new System.Drawing.Point(6, 105);
            this.lblCleanCustomWords.Name = "lblCleanCustomWords";
            this.lblCleanCustomWords.Size = new System.Drawing.Size(196, 62);
            this.lblCleanCustomWords.TabIndex = 20;
            // 
            // txtCleanCustomWords
            // 
            this.txtCleanCustomWords.Location = new System.Drawing.Point(6, 22);
            this.txtCleanCustomWords.Multiline = true;
            this.txtCleanCustomWords.Name = "txtCleanCustomWords";
            this.txtCleanCustomWords.Size = new System.Drawing.Size(196, 80);
            this.txtCleanCustomWords.TabIndex = 19;
            this.txtCleanCustomWords.TextChanged += new System.EventHandler(this.txtCleanCustomWords_TextChanged);
            // 
            // chkRemoveLastLine
            // 
            this.chkRemoveLastLine.AutoSize = true;
            this.chkRemoveLastLine.Location = new System.Drawing.Point(30, 217);
            this.chkRemoveLastLine.Name = "chkRemoveLastLine";
            this.chkRemoveLastLine.Size = new System.Drawing.Size(118, 19);
            this.chkRemoveLastLine.TabIndex = 16;
            this.chkRemoveLastLine.Text = "Remove Last Line";
            this.chkRemoveLastLine.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSpamPostAuthors);
            this.groupBox4.Controls.Add(this.txtSpamPostAuthors);
            this.groupBox4.Location = new System.Drawing.Point(220, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 170);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spam Post Author\'s";
            // 
            // lblSpamPostAuthors
            // 
            this.lblSpamPostAuthors.Location = new System.Drawing.Point(6, 105);
            this.lblSpamPostAuthors.Name = "lblSpamPostAuthors";
            this.lblSpamPostAuthors.Size = new System.Drawing.Size(196, 62);
            this.lblSpamPostAuthors.TabIndex = 20;
            // 
            // txtSpamPostAuthors
            // 
            this.txtSpamPostAuthors.Location = new System.Drawing.Point(6, 22);
            this.txtSpamPostAuthors.Multiline = true;
            this.txtSpamPostAuthors.Name = "txtSpamPostAuthors";
            this.txtSpamPostAuthors.Size = new System.Drawing.Size(196, 80);
            this.txtSpamPostAuthors.TabIndex = 19;
            this.txtSpamPostAuthors.TextChanged += new System.EventHandler(this.txtSpamPostAuthors_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSpamWords);
            this.groupBox3.Controls.Add(this.txtSpamWords);
            this.groupBox3.Location = new System.Drawing.Point(6, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 170);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spam Word\'s";
            // 
            // lblSpamWords
            // 
            this.lblSpamWords.Location = new System.Drawing.Point(6, 105);
            this.lblSpamWords.Name = "lblSpamWords";
            this.lblSpamWords.Size = new System.Drawing.Size(196, 62);
            this.lblSpamWords.TabIndex = 20;
            // 
            // txtSpamWords
            // 
            this.txtSpamWords.Location = new System.Drawing.Point(6, 22);
            this.txtSpamWords.Multiline = true;
            this.txtSpamWords.Name = "txtSpamWords";
            this.txtSpamWords.Size = new System.Drawing.Size(196, 80);
            this.txtSpamWords.TabIndex = 19;
            this.txtSpamWords.TextChanged += new System.EventHandler(this.txtSpamWords_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Use , Seprator For Diffrent Between Elements";
            // 
            // chkRemoveText
            // 
            this.chkRemoveText.AutoSize = true;
            this.chkRemoveText.Location = new System.Drawing.Point(95, 190);
            this.chkRemoveText.Name = "chkRemoveText";
            this.chkRemoveText.Size = new System.Drawing.Size(93, 19);
            this.chkRemoveText.TabIndex = 20;
            this.chkRemoveText.Text = "Remove Text";
            this.chkRemoveText.UseVisualStyleBackColor = true;
            this.chkRemoveText.CheckedChanged += new System.EventHandler(this.chkRemoveText_CheckedChanged);
            // 
            // chkIgnoreMediaMessages
            // 
            this.chkIgnoreMediaMessages.AutoSize = true;
            this.chkIgnoreMediaMessages.Location = new System.Drawing.Point(440, 489);
            this.chkIgnoreMediaMessages.Name = "chkIgnoreMediaMessages";
            this.chkIgnoreMediaMessages.Size = new System.Drawing.Size(150, 19);
            this.chkIgnoreMediaMessages.TabIndex = 16;
            this.chkIgnoreMediaMessages.Text = "Ignore Media Messages";
            this.chkIgnoreMediaMessages.UseVisualStyleBackColor = true;
            this.chkIgnoreMediaMessages.CheckedChanged += new System.EventHandler(this.chkIgnoreMediaMessages_CheckedChanged);
            // 
            // chkDeletePostsWithForeignMentions
            // 
            this.chkDeletePostsWithForeignMentions.AutoSize = true;
            this.chkDeletePostsWithForeignMentions.Checked = true;
            this.chkDeletePostsWithForeignMentions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeletePostsWithForeignMentions.Location = new System.Drawing.Point(18, 489);
            this.chkDeletePostsWithForeignMentions.Name = "chkDeletePostsWithForeignMentions";
            this.chkDeletePostsWithForeignMentions.Size = new System.Drawing.Size(214, 19);
            this.chkDeletePostsWithForeignMentions.TabIndex = 16;
            this.chkDeletePostsWithForeignMentions.Text = "Delete Posts With Foreign Mentions";
            this.chkDeletePostsWithForeignMentions.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreForwardedMessages
            // 
            this.chkIgnoreForwardedMessages.AutoSize = true;
            this.chkIgnoreForwardedMessages.Checked = true;
            this.chkIgnoreForwardedMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreForwardedMessages.Location = new System.Drawing.Point(251, 489);
            this.chkIgnoreForwardedMessages.Name = "chkIgnoreForwardedMessages";
            this.chkIgnoreForwardedMessages.Size = new System.Drawing.Size(173, 19);
            this.chkIgnoreForwardedMessages.TabIndex = 16;
            this.chkIgnoreForwardedMessages.Text = "Ignore Forwarded Messages";
            this.chkIgnoreForwardedMessages.UseVisualStyleBackColor = true;
            // 
            // grpIgnoreMessagesTypes
            // 
            this.grpIgnoreMessagesTypes.Controls.Add(this.chkIgnoreMessageTypeVoiceMessages);
            this.grpIgnoreMessagesTypes.Controls.Add(this.chkIgnoreMessageTypeGifs);
            this.grpIgnoreMessagesTypes.Controls.Add(this.chkIgnoreMessageTypeFiles);
            this.grpIgnoreMessagesTypes.Controls.Add(this.chkIgnoreMessageTypeMusics);
            this.grpIgnoreMessagesTypes.Controls.Add(this.chkIgnoreMessageTypeVideos);
            this.grpIgnoreMessagesTypes.Controls.Add(this.chkIgnoreMessageTypePhotos);
            this.grpIgnoreMessagesTypes.Location = new System.Drawing.Point(559, 70);
            this.grpIgnoreMessagesTypes.Name = "grpIgnoreMessagesTypes";
            this.grpIgnoreMessagesTypes.Size = new System.Drawing.Size(334, 104);
            this.grpIgnoreMessagesTypes.TabIndex = 21;
            this.grpIgnoreMessagesTypes.TabStop = false;
            this.grpIgnoreMessagesTypes.Text = "Ignore Message Types :";
            // 
            // chkIgnoreMessageTypeVoiceMessages
            // 
            this.chkIgnoreMessageTypeVoiceMessages.AutoSize = true;
            this.chkIgnoreMessageTypeVoiceMessages.Location = new System.Drawing.Point(171, 58);
            this.chkIgnoreMessageTypeVoiceMessages.Name = "chkIgnoreMessageTypeVoiceMessages";
            this.chkIgnoreMessageTypeVoiceMessages.Size = new System.Drawing.Size(111, 19);
            this.chkIgnoreMessageTypeVoiceMessages.TabIndex = 1;
            this.chkIgnoreMessageTypeVoiceMessages.Text = "Voice Message\'s";
            this.chkIgnoreMessageTypeVoiceMessages.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeGifs
            // 
            this.chkIgnoreMessageTypeGifs.AutoSize = true;
            this.chkIgnoreMessageTypeGifs.Location = new System.Drawing.Point(29, 58);
            this.chkIgnoreMessageTypeGifs.Name = "chkIgnoreMessageTypeGifs";
            this.chkIgnoreMessageTypeGifs.Size = new System.Drawing.Size(49, 19);
            this.chkIgnoreMessageTypeGifs.TabIndex = 2;
            this.chkIgnoreMessageTypeGifs.Text = "Gif\'s";
            this.chkIgnoreMessageTypeGifs.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeFiles
            // 
            this.chkIgnoreMessageTypeFiles.AutoSize = true;
            this.chkIgnoreMessageTypeFiles.Location = new System.Drawing.Point(101, 58);
            this.chkIgnoreMessageTypeFiles.Name = "chkIgnoreMessageTypeFiles";
            this.chkIgnoreMessageTypeFiles.Size = new System.Drawing.Size(52, 19);
            this.chkIgnoreMessageTypeFiles.TabIndex = 2;
            this.chkIgnoreMessageTypeFiles.Text = "File\'s";
            this.chkIgnoreMessageTypeFiles.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeMusics
            // 
            this.chkIgnoreMessageTypeMusics.AutoSize = true;
            this.chkIgnoreMessageTypeMusics.Location = new System.Drawing.Point(171, 22);
            this.chkIgnoreMessageTypeMusics.Name = "chkIgnoreMessageTypeMusics";
            this.chkIgnoreMessageTypeMusics.Size = new System.Drawing.Size(66, 19);
            this.chkIgnoreMessageTypeMusics.TabIndex = 3;
            this.chkIgnoreMessageTypeMusics.Text = "Music\'s";
            this.chkIgnoreMessageTypeMusics.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypeVideos
            // 
            this.chkIgnoreMessageTypeVideos.AutoSize = true;
            this.chkIgnoreMessageTypeVideos.Location = new System.Drawing.Point(101, 23);
            this.chkIgnoreMessageTypeVideos.Name = "chkIgnoreMessageTypeVideos";
            this.chkIgnoreMessageTypeVideos.Size = new System.Drawing.Size(64, 19);
            this.chkIgnoreMessageTypeVideos.TabIndex = 4;
            this.chkIgnoreMessageTypeVideos.Text = "Video\'s";
            this.chkIgnoreMessageTypeVideos.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreMessageTypePhotos
            // 
            this.chkIgnoreMessageTypePhotos.AutoSize = true;
            this.chkIgnoreMessageTypePhotos.Location = new System.Drawing.Point(29, 23);
            this.chkIgnoreMessageTypePhotos.Name = "chkIgnoreMessageTypePhotos";
            this.chkIgnoreMessageTypePhotos.Size = new System.Drawing.Size(66, 19);
            this.chkIgnoreMessageTypePhotos.TabIndex = 5;
            this.chkIgnoreMessageTypePhotos.Text = "Photo\'s";
            this.chkIgnoreMessageTypePhotos.UseVisualStyleBackColor = true;
            // 
            // frmContentChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 521);
            this.ControlBox = false;
            this.Controls.Add(this.grpIgnoreMessagesTypes);
            this.Controls.Add(this.chkRemoveText);
            this.Controls.Add(this.grpTextPolicy);
            this.Controls.Add(this.chkDeletePostsWithForeignMentions);
            this.Controls.Add(this.chkIgnoreForwardedMessages);
            this.Controls.Add(this.chkIgnoreMediaMessages);
            this.Controls.Add(this.chkDntSendAlbums);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChannelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectSourceChannel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmContentChannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content Editor";
            this.Load += new System.EventHandler(this.frmContentChannel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpTextPolicy.ResumeLayout(false);
            this.grpTextPolicy.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpIgnoreMessagesTypes.ResumeLayout(false);
            this.grpIgnoreMessagesTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}