using ChannelSniffer.Model;
using Dilangram.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;

namespace Dilangram
{
    internal static class Program
    {
        public static string InputTextDialog { get; internal set; }
        
        // Load API credentials from configuration file
        internal static int api_id => AppConfig.ApiId;
        internal static string api_hash => AppConfig.ApiHash;

        public static List<ChannelJob> AppJobs = new List<ChannelJob>();

        public static Messages_Chats ChatList;
        public static InputPeer GetInputPeerForChatId(long chatId)
        {
            return Program.ChatList.chats[chatId];
        }
        public static string GetChatTitle(long chatId)
        {
            return Program.ChatList.chats[chatId].Title;
        }


        #region Logger
        //frm Main Logger
        public static List<string> logs = new List<string>();

        public static void Log(string log)
        {
            Program.logs.Add(DateTime.Now.ToString("HH:mm:ss") + "  ➡️  " + log);

            if (Program.logs.Count > 20)
            {
                logs.RemoveAt(0);
            }
        }
        #endregion






        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ensure configuration file exists
            AppConfig.CreateConfigFile();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.Run(new frmMain());
        }



    }
}
