using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp.Models.Client
{
    public class Response
    {

        [JsonConverter(typeof(UnixEpochConverter))]
        [JsonProperty("reset")]
        public DateTime Reset { get; set; }

        [JsonProperty("tier")]
        public String Tier { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("email")]
        public String Email { get; set; }

        [JsonProperty("requests")]
        public int Requests { get; set; }

        [JsonProperty("api_key")]
        public String APIKey { get; set; }

        [JsonProperty("quota")]
        public int Quota { get; set; }

         

    }
}
