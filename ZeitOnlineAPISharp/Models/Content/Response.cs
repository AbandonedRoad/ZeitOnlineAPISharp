using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ZeitOnlineAPISharp.Models.Content
{
    public class Response
    {
        [JsonProperty("teaser_title")]
        public String TeaserTitle { get; set; }

        [JsonProperty("uuid")]
        public String UUID { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("uri")]
        public String URI { get; set; }

        [JsonProperty("relations")]
        public List<Relation> Relations { get; set; }
        
        [JsonProperty("supertitle")]
        public String SuperTitle { get; set; }

        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("teaser_text")]
        public String TeaserText { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("creators")]
        public List<Creator> Creators { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
    }
}
