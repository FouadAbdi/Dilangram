
namespace Dilangram.Dialog
{
    partial class frmChatSelector
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
            lstChats = new ListBox();
            btnOK = new Button();
            btnCancel = new Button();
            txtFilterText = new TextBox();
            SuspendLayout();
            // 
            // lstChats
            // 
            lstChats.FormattingEnabled = true;
            lstChats.ItemHeight = 25;
            lstChats.Location = new Point(17, 82);
            lstChats.Margin = new Padding(4, 5, 4, 5);
            lstChats.Name = "lstChats";
            lstChats.Size = new Size(360, 429);
            lstChats.TabIndex = 2;
            lstChats.SelectedIndexChanged += lstChats_SelectedIndexChanged;
            lstChats.MouseDoubleClick += lstChats_MouseDoubleClick;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(203, 538);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(137, 47);
            btnOK.TabIndex = 3;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(53, 538);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 47);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFilterText
            // 
            txtFilterText.Location = new Point(53, 22);
            txtFilterText.Margin = new Padding(4, 5, 4, 5);
            txtFilterText.Name = "txtFilterText";
            txtFilterText.Size = new Size(270, 31);
            txtFilterText.TabIndex = 5;
            txtFilterText.TextChanged += txtFilterText_TextChanged;
            // 
            // frmChatSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 602);
            ControlBox = false;
            Controls.Add(txtFilterText);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(lstChats);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmChatSelector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelease Select A Chat :";
            Load += frmChatSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstChats;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFilterText;
    }
}