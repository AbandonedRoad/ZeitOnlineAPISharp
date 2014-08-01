using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp.Models.Keyword
{
    public class Match
    {
        [JsonProperty("subtitle")]
        public String Subtitle { get; set; }

        [JsonProperty("uuid")]
        public String UUID { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }

        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("uri")]
        public String URI { get; set; }

        [JsonProperty("supertitle")]
        public String SuperTitle { get; set; }

        [JsonProperty("teaser_text")]
        public String TeaserText { get; set; }

        [JsonProperty("teaser_title")]
        public String TeaserTitle { get; set; }
        
        /*
"subtitle": "Die Europ\u00e4ische Union hat Sanktionen gegen drei Vertraute des russischen Pr\u00e4sidenten erlassen. Sie d\u00fcrfen k\u00fcnftig nicht in die EU einreisen, ihre Konten wurden gesperrt.", 
      "uuid": "7AGae8ROEL2utzGZpVo47F", 
      "title": "EU verh\u00e4ngt Einreiseverbote gegen Vertraute Putins", 
      "href": "http://www.zeit.de/wirtschaft/2014-07/eu-sanktionen-russland-wladimir-putin", 
      "release_date": "2014-07-30T20:14:20Z", 
      "uri": "http://api.zeit.de/content/7AGae8ROEL2utzGZpVo47F", 
      "supertitle": "Sanktionen", 
      "teaser_text": "Die Europ\u00e4ische Union hat Sanktionen gegen drei Vertraute des russischen Pr\u00e4sidenten erlassen. Sie d\u00fcrfen k\u00fcnftig nicht in die EU einreisen, ihre Konten wurden gesperrt.", 
      "teaser_title": "EU verh\u00e4ngt Einreiseverbote gegen Vertraute Putins"
         * */
    }
}
