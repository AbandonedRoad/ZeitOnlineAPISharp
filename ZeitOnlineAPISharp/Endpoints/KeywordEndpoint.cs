using Newtonsoft.Json;
using System;
using ZeitOnlineAPISharp.Models;
using ZeitOnlineAPISharp.Models.Keyword;

namespace ZeitOnlineAPISharp.Endpoints
{
    public class KeywordEndpoint
    {

        protected API API { get; set; }

        public KeywordEndpoint(API api)
        {
            this.API = api;
        }

        public Response Query(String keyword)
        {
            String url = String.Format("http://api.zeit.de/keyword/{0}?limit={1}&api_key={2}", keyword, this.API.Limit, this.API.APIKey);
            return APIRequester.Request<Response>(url, this.API);
        }

        public Response Query(String keyword, int offset)
        {
            String url = String.Format("http://api.zeit.de/keyword/{0}?limit={1}&api_key={2}&offset={3}", keyword, this.API.Limit, this.API.APIKey, offset);
            return APIRequester.Request<Response>(url, this.API);
        }
    }
}
