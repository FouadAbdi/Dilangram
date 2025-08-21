
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
            this.lstChats = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstChats
            // 
            this.lstChats.FormattingEnabled = true;
            this.lstChats.ItemHeight = 15;
            this.lstChats.Location = new System.Drawing.Point(12, 49);
            this.lstChats.Name = "lstChats";
            this.lstChats.Size = new System.Drawing.Size(253, 259);
            this.lstChats.TabIndex = 2;
            this.lstChats.SelectedIndexChanged += new System.EventHandler(this.lstChats_SelectedIndexChanged);
            this.lstChats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstChats_MouseDoubleClick);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(142, 323);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(37, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFilterText
            // 
            this.txtFilterText.Location = new System.Drawing.Point(37, 13);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(190, 23);
            this.txtFilterText.TabIndex = 5;
            this.txtFilterText.TextChanged += new System.EventHandler(this.txtFilterText_TextChanged);
            // 
            // frmChatSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 361);
            this.ControlBox = false;
            this.Controls.Add(this.txtFilterText);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstChats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChatSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelease Select A Chat :";
            this.Load += new System.EventHandler(this.frmChatSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChats;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFilterText;
    }
}