namespace DilangramCore.Forms
{
    partial class frmUnlock
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
            btnOK = new Button();
            btnSelectSourceChat = new Button();
            label4 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(22, 72);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(496, 60);
            btnOK.TabIndex = 5;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnSelectSourceChat
            // 
            btnSelectSourceChat.Location = new Point(101, -484);
            btnSelectSourceChat.Margin = new Padding(4, 5, 4, 5);
            btnSelectSourceChat.Name = "btnSelectSourceChat";
            btnSelectSourceChat.Size = new Size(239, 42);
            btnSelectSourceChat.TabIndex = 4;
            btnSelectSourceChat.Text = "From : ";
            btnSelectSourceChat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-22, -474);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 3;
            label4.Text = "Source Chat :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(22, 14);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(496, 31);
            txtPassword.TabIndex = 6;
            // 
            // frmUnlock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 153);
            Controls.Add(txtPassword);
            Controls.Add(btnOK);
            Controls.Add(btnSelectSourceChat);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmUnlock";
            Text = "frmUnlock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnSelectSourceChat;
        private Label label4;
        private TextBox txtPassword;
    }
}