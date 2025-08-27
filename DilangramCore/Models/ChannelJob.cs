using System.Collections.Generic;
using System.Text.Json.Serialization;
using TL;

namespace DilangramCore.Model
{
    public class ChannelJob
    {
        public string Title { get; set; }
        public string UserName { get; set; }
        public long ChatId { get; set; } = 0;

        [JsonIgnore]
        public InputPeer ChatPeer{ get; set; }

        public List<SourceChannel> ContentChannels { get; set; }

    }
}
