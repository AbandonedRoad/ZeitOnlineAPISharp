using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp.Models.Department
{
    public class Response
    {

        [JsonProperty("parent")]
        public String Parent { get; set; }

        [JsonProperty("matches")]
        public List<ZeitOnlineAPISharp.Models.Keyword.Match> Matches { get; set; }

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


        [JsonProperty("id")]
        public String ID { get; set; }
    }
}
