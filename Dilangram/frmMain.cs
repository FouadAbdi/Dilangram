using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using TL;
using Dilangram.Dialog;
using System.Globalization;
using System.IO;

namespace Dilangram
{
    public partial class frmMain : Form
    {
        private WTelegram.Client tgClient;

        public frmMain()
        {
            InitializeComponent();
            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(s);
        }


        static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return "20833282";
                case "api_hash": return "6d4517a3e6c32f17e5ac2efe026039e2";

                case "phone_number":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                case "verification_code":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                case "first_name": return "John";      // if sign-up is required
                case "last_name": return "Doe";        // if sign-up is required

                case "password":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                default: return null;                  // let WTelegramClient decide the default config
            }
        }


        private async void frmMain_Load(object sender, EventArgs e)
        {
            tgClient = new WTelegram.Client(Config);



            var user = await tgClient.LoginUserIfNeeded();



            //Load Profile
            var users = await tgClient.Users_GetUsers(InputUser.Self);
            var logedInUser = users[0] as User;

        }



        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            tgClient?.Dispose();
        }


    }
}
