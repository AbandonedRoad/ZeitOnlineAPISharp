using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp.Models.Content
{
    public class Response
    {
        [JsonProperty("matches")]
        public List<Match> Matches { get; set; }
    }
}
