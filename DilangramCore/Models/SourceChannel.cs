using Dilangram.Enums;

namespace DilangramCore.Model
{
    public class SourceChannel
    {
        public long ChannelId { get; set; } = -1;
        public string UserName { get; set; }
        public SourceChannelMentions MentionPolicy { get; set; }
        public bool DntSendPostLinks { get; set; }
        public bool DntSendPostHyperLinks { get; set; }
        public bool DntSendAlbums { get; set; } = false;

        public string[] SpamWords { get; set; }
        public string[] SpamPostAuthors { get; set; }
        public string[] CleanCustomWords { get; set; }


        public bool IgnoreMediaMessages { get; set; }
        public bool IgnoreForwardedMessages { get; set; } = true;

        public bool RemoveText { get; set; }

        public bool RemoveFirstLine { get; set; }
        public bool RemoveLastLine { get; set; }

        public string AppendText { get; set; }
        public string PrependText { get; set; }

        public bool DeletePostsWithForeignMentions { get; set; } = true;

        public bool RemoveAllLinkInCaption { get; set; } = false;
        public bool AutoTranslateCaption { get; set; } = false;




        public bool IgnoreMessageTypePhoto { get; set; } = false;
        public bool IgnoreMessageTypeVideo { get; set; } = false;
        public bool IgnoreMessageTypeMusic { get; set; } = false;
        public bool IgnoreMessageTypeVoice { get; set; } = false;
        public bool IgnoreMessageTypeFile { get; set; } = false;
        public bool IgnoreMessageTypeGif { get; set; } = false;
    }
}
