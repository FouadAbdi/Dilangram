using DilangramCore;
using DilangramCore.Model;
using TL;

namespace Dilangram
{
    internal static class Program
    {

        public static MainForm mainForm;
        public static string InputTextDialog { get; internal set; }

        internal static int api_id = 0000000;
        internal static string api_hash = "00000000000000000000000000000";

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
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            mainForm= new MainForm();
            Application.Run(mainForm);
        }
    }
}