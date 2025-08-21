using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dilangram.Dialog
{
    public partial class frmInputTextbox : Form
    {
        
        public frmInputTextbox(string title)
        {
            InitializeComponent();

            lblTitle.Text = title;
        }

        private void frmInputTextbox_Load(object sender, EventArgs e)
        {
            
        }
        private void frmInputTextbox_Load_1(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            Program.InputTextDialog = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
