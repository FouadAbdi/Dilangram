
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioSchuldedMessage = new System.Windows.Forms.RadioButton();
            this.grpSchulded = new System.Windows.Forms.GroupBox();
            this.numSchuledTimeMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rdioOnceMass = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numTotalMessageCount = new System.Windows.Forms.NumericUpDown();
            this.chkJustMediaMessage = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectSourceChat = new System.Windows.Forms.Button();
            this.btnSelectTargetChat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpSchulded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSchuledTimeMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalMessageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Chat :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(188, 418);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 36);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioSchuldedMessage);
            this.groupBox1.Controls.Add(this.grpSchulded);
            this.groupBox1.Controls.Add(this.rdioOnceMass);
            this.groupBox1.Location = new System.Drawing.Point(14, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Type";
            // 
            // rdioSchuldedMessage
            // 
            this.rdioSchuldedMessage.AutoSize = true;
            this.rdioSchuldedMessage.Location = new System.Drawing.Point(22, 47);
            this.rdioSchuldedMessage.Name = "rdioSchuldedMessage";
            this.rdioSchuldedMessage.Size = new System.Drawing.Size(116, 19);
            this.rdioSchuldedMessage.TabIndex = 0;
            this.rdioSchuldedMessage.Text = "Schulde Message";
            this.rdioSchuldedMessage.UseVisualStyleBackColor = true;
            this.rdioSchuldedMessage.CheckedChanged += new System.EventHandler(this.rdioSchuldedMessage_CheckedChanged);
            // 
            // grpSchulded
            // 
            this.grpSchulded.Controls.Add(this.numSchuledTimeMinute);
            this.grpSchulded.Controls.Add(this.label2);
            this.grpSchulded.Enabled = false;
            this.grpSchulded.Location = new System.Drawing.Point(11, 51);
            this.grpSchulded.Name = "grpSchulded";
            this.grpSchulded.Size = new System.Drawing.Size(237, 61);
            this.grpSchulded.TabIndex = 1;
            this.grpSchulded.TabStop = false;
            this.grpSchulded.Text = "                          ";
            // 
            // numSchuledTimeMinute
            // 
            this.numSchuledTimeMinute.Location = new System.Drawing.Point(60, 22);
            this.numSchuledTimeMinute.Name = "numSchuledTimeMinute";
            this.numSchuledTimeMinute.Size = new System.Drawing.Size(48, 23);
            this.numSchuledTimeMinute.TabIndex = 0;
            this.numSchuledTimeMinute.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minute";
            // 
            // rdioOnceMass
            // 
            this.rdioOnceMass.AutoSize = true;
            this.rdioOnceMass.Checked = true;
            this.rdioOnceMass.Location = new System.Drawing.Point(23, 22);
            this.rdioOnceMass.Name = "rdioOnceMass";
            this.rdioOnceMass.Size = new System.Drawing.Size(83, 19);
            this.rdioOnceMass.TabIndex = 0;
            this.rdioOnceMass.TabStop = true;
            this.rdioOnceMass.Text = "Once mass";
            this.rdioOnceMass.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Message Count :";
            // 
            // numTotalMessageCount
            // 
            this.numTotalMessageCount.Location = new System.Drawing.Point(113, 138);
            this.numTotalMessageCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTotalMessageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalMessageCount.Name = "numTotalMessageCount";
            this.numTotalMessageCount.Size = new System.Drawing.Size(61, 23);
            this.numTotalMessageCount.TabIndex = 0;
            this.numTotalMessageCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkJustMediaMessage
            // 
            this.chkJustMediaMessage.Location = new System.Drawing.Point(14, 196);
            this.chkJustMediaMessage.Name = "chkJustMediaMessage";
            this.chkJustMediaMessage.Size = new System.Drawing.Size(180, 24);
            this.chkJustMediaMessage.TabIndex = 4;
            this.chkJustMediaMessage.Text = "Send Just Media Message";
            this.chkJustMediaMessage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Source Chat :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSelectSourceChat
            // 
            this.btnSelectSourceChat.Location = new System.Drawing.Point(111, 16);
            this.btnSelectSourceChat.Name = "btnSelectSourceChat";
            this.btnSelectSourceChat.Size = new System.Drawing.Size(167, 25);
            this.btnSelectSourceChat.TabIndex = 2;
            this.btnSelectSourceChat.Text = "From : ";
            this.btnSelectSourceChat.UseVisualStyleBackColor = true;
            this.btnSelectSourceChat.Click += new System.EventHandler(this.btnSelectSourceChat_Click);
            // 
            // btnSelectTargetChat
            // 
            this.btnSelectTargetChat.Location = new System.Drawing.Point(111, 54);
            this.btnSelectTargetChat.Name = "btnSelectTargetChat";
            this.btnSelectTargetChat.Size = new System.Drawing.Size(167, 25);
            this.btnSelectTargetChat.TabIndex = 2;
            this.btnSelectTargetChat.Text = "To :";
            this.btnSelectTargetChat.UseVisualStyleBackColor = true;
            this.btnSelectTargetChat.Click += new System.EventHandler(this.btnSelectTargetChat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Offset Count :";
            // 
            // numOffset
            // 
            this.numOffset.Location = new System.Drawing.Point(113, 106);
            this.numOffset.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(61, 23);
            this.numOffset.TabIndex = 0;
            this.numOffset.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.AutoSize = true;
            this.lblPleaseWait.Location = new System.Drawing.Point(205, 176);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(73, 15);
            this.lblPleaseWait.TabIndex = 1;
            this.lblPleaseWait.Text = "Please Wait..";
            this.lblPleaseWait.Visible = false;
            this.lblPleaseWait.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmSendMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 469);
            this.ControlBox = false;
            this.Controls.Add(this.chkJustMediaMessage);
            this.Controls.Add(this.numOffset);
            this.Controls.Add(this.numTotalMessageCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelectTargetChat);
            this.Controls.Add(this.btnSelectSourceChat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPleaseWait);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSendMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Messages";
            this.Load += new System.EventHandler(this.frmSendMessages_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSchulded.ResumeLayout(false);
            this.grpSchulded.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSchuledTimeMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalMessageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}