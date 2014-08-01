using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp.Models.Keyword
{
    public class Response
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("matches")]
        public List<Match> Matches { get; set; }

        [JsonProperty("lexical")]
        public String Lexical { get; set; }

        [JsonProperty("uri")]
        public String URI { get; set; }

        [JsonProperty("value")]
        public String Value { get; set; }

        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("found")]
        public int Found { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }

        [JsonProperty("id")]
        public String ID { get; set; }


    }
}
