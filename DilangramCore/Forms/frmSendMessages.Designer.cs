
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
            groupBox1.SuspendLayout();
            grpSchulded.SuspendLayout();
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
            btnCancel.Location = new Point(14, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(188, 418);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(105, 36);
            btnOK.TabIndex = 2;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdioSchuldedMessage);
            groupBox1.Controls.Add(grpSchulded);
            groupBox1.Controls.Add(rdioOnceMass);
            groupBox1.Location = new Point(14, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 143);
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
            numOffset.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOffset.Name = "numOffset";
            numOffset.Size = new Size(61, 23);
            numOffset.TabIndex = 0;
            numOffset.Value = new decimal(new int[] { 100, 0, 0, 0 });
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
            // frmSendMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 518);
            ControlBox = false;
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
            Text = "Send Messages";
            Load += frmSendMessages_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpSchulded.ResumeLayout(false);
            grpSchulded.PerformLayout();
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
    }
}