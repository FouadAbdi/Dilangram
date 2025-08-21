
namespace Dilangram.Forms
{
    partial class frmJobEditor
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
            btnSelectTargetChannel = new Button();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtChatId = new TextBox();
            btnDelete = new Button();
            btnOk = new Button();
            btnCancel = new Button();
            lstJobContentChannel = new ListBox();
            label4 = new Label();
            btnAddContentChannel = new Button();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // btnSelectTargetChannel
            // 
            btnSelectTargetChannel.Location = new Point(57, 77);
            btnSelectTargetChannel.Name = "btnSelectTargetChannel";
            btnSelectTargetChannel.Size = new Size(155, 33);
            btnSelectTargetChannel.TabIndex = 0;
            btnSelectTargetChannel.Text = "Select Target Channel";
            btnSelectTargetChannel.UseVisualStyleBackColor = true;
            btnSelectTargetChannel.Click += btnSelectTargetChannel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Title : ";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(57, 13);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(174, 23);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 48);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "User Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 120);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Chat Id : ";
            // 
            // txtChatId
            // 
            txtChatId.Location = new Point(79, 117);
            txtChatId.Name = "txtChatId";
            txtChatId.ReadOnly = true;
            txtChatId.Size = new Size(152, 23);
            txtChatId.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(98, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(174, 388);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 30);
            btnOk.TabIndex = 5;
            btnOk.Text = "&OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(27, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lstJobContentChannel
            // 
            lstJobContentChannel.FormattingEnabled = true;
            lstJobContentChannel.ItemHeight = 15;
            lstJobContentChannel.Location = new Point(12, 181);
            lstJobContentChannel.Name = "lstJobContentChannel";
            lstJobContentChannel.Size = new Size(241, 199);
            lstJobContentChannel.TabIndex = 6;
            lstJobContentChannel.SelectedIndexChanged += lstJobContentChannel_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Content Channel's : ";
            // 
            // btnAddContentChannel
            // 
            btnAddContentChannel.AutoSize = true;
            btnAddContentChannel.Location = new Point(148, 153);
            btnAddContentChannel.Name = "btnAddContentChannel";
            btnAddContentChannel.Size = new Size(83, 25);
            btnAddContentChannel.TabIndex = 5;
            btnAddContentChannel.Text = "&Add";
            btnAddContentChannel.UseVisualStyleBackColor = true;
            btnAddContentChannel.Click += btnAddContentChannel_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(90, 45);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(141, 23);
            txtUserName.TabIndex = 4;
            // 
            // frmJobEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 435);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnDelete);
            Controls.Add(lstJobContentChannel);
            Controls.Add(btnAddContentChannel);
            Controls.Add(txtChatId);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(btnSelectTargetChannel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmJobEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job";
            Load += frmJobEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSelectTargetChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChatId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstJobContentChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddContentChannel;
        private TextBox txtUserName;
    }
}