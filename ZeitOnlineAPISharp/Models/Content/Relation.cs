using Newtonsoft.Json;
using System;


namespace ZeitOnlineAPISharp.Models.Content
{
    public class Relation
    {
        [JsonProperty("uri")]
        public String Uri { get; set; }

        [JsonProperty("rel")]
        public String Rel { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }
    }
}
