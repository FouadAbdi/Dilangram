
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
            this.btnSelectTargetChannel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChatId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstJobContentChannel = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddContentChannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectTargetChannel
            // 
            this.btnSelectTargetChannel.Location = new System.Drawing.Point(57, 77);
            this.btnSelectTargetChannel.Name = "btnSelectTargetChannel";
            this.btnSelectTargetChannel.Size = new System.Drawing.Size(155, 33);
            this.btnSelectTargetChannel.TabIndex = 0;
            this.btnSelectTargetChannel.Text = "Select Target Channel";
            this.btnSelectTargetChannel.UseVisualStyleBackColor = true;
            this.btnSelectTargetChannel.Click += new System.EventHandler(this.btnSelectTargetChannel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title : ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(57, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(174, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(90, 45);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 23);
            this.txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chat Id : ";
            // 
            // txtChatId
            // 
            this.txtChatId.Location = new System.Drawing.Point(79, 117);
            this.txtChatId.Name = "txtChatId";
            this.txtChatId.ReadOnly = true;
            this.txtChatId.Size = new System.Drawing.Size(152, 23);
            this.txtChatId.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(176, 383);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(65, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(29, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstJobContentChannel
            // 
            this.lstJobContentChannel.FormattingEnabled = true;
            this.lstJobContentChannel.ItemHeight = 15;
            this.lstJobContentChannel.Location = new System.Drawing.Point(12, 181);
            this.lstJobContentChannel.Name = "lstJobContentChannel";
            this.lstJobContentChannel.Size = new System.Drawing.Size(241, 199);
            this.lstJobContentChannel.TabIndex = 6;
            this.lstJobContentChannel.SelectedIndexChanged += new System.EventHandler(this.lstJobContentChannel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content Channel\'s : ";
            // 
            // btnAddContentChannel
            // 
            this.btnAddContentChannel.AutoSize = true;
            this.btnAddContentChannel.Location = new System.Drawing.Point(148, 153);
            this.btnAddContentChannel.Name = "btnAddContentChannel";
            this.btnAddContentChannel.Size = new System.Drawing.Size(83, 25);
            this.btnAddContentChannel.TabIndex = 5;
            this.btnAddContentChannel.Text = "&Add";
            this.btnAddContentChannel.UseVisualStyleBackColor = true;
            this.btnAddContentChannel.Click += new System.EventHandler(this.btnAddContentChannel_Click);
            // 
            // frmJobEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 414);
            this.ControlBox = false;
            this.Controls.Add(this.lstJobContentChannel);
            this.Controls.Add(this.btnAddContentChannel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtChatId);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectTargetChannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmJobEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job";
            this.Load += new System.EventHandler(this.frmJobEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectTargetChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChatId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstJobContentChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddContentChannel;
    }
}