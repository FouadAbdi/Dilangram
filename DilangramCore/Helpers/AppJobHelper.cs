using DilangramCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dilangram.Helpers
{
    public static class AppJobHelper
    {

        private static string fileName = "ApplicationJob.config";
        static AppJobHelper()
        {
            if (System.IO.File.Exists(fileName) is false)
            {
                SaveJobs();
            }
            LoadJobs();
        }


        public static void LoadJobs()
        {
            string json = System.IO.File.ReadAllText(fileName, Encoding.UTF8);
            Program.AppJobs = JsonSerializer.Deserialize<List<ChannelJob>>(json);
        }

        public static void SaveJobs()
        {
            string json = JsonSerializer.Serialize(Program.AppJobs);
            System.IO.File.WriteAllText(fileName, json, Encoding.UTF8);
        }


        public static ChannelJob GetJobByChannlId(long channelId)
        {
            return Program.AppJobs.FirstOrDefault(x => x.ChatId == channelId);
        }


        public static void RemoveJob(ChannelJob channelJob)
        {
            Program.AppJobs.Remove(channelJob);
            SaveJobs();
        }

        public static void AddJob(ChannelJob channelJob)
        {
            Program.AppJobs.Add(channelJob);
            SaveJobs();
        }


        #region ConfigJobs


        public static IEnumerable<ChannelJob> GetJobsForChannel(long chatId)
        {
            return Program.AppJobs.Where(x => x.ContentChannels.Count(x => x.ChannelId == chatId) > 0);
        }


        #endregion


    }
}
