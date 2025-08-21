using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilangramCore.Forms
{
    public partial class frmUnlock : Form
    {
        public frmUnlock()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().ToLower() == "hisir244")
            {
                Dilangram.Program.mainForm.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Pass");
            }
        }
    }
}
