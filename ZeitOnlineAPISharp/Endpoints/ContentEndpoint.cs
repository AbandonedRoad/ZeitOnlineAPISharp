using Newtonsoft.Json;
using System;
using ZeitOnlineAPISharp.Models.Content;

namespace ZeitOnlineAPISharp.Endpoints
{
    public class ContentEndpoint
    {
        protected API API { get; set; }

        public ContentEndpoint(API api)
        {
            this.API = api;
        }


        public Response Query()
        {
            String url = String.Format("http://api.zeit.de/content?api_key={0}&limit={1}", this.API.APIKey, this.API.Limit);
            return APIRequester.Request<Response>(url, this.API);
        }

        public Response Query(int offset)
        {
            String url = String.Format("http://api.zeit.de/content?api_key={0}&limit={1}&offset={2}", this.API.APIKey, this.API.Limit, offset);
            return APIRequester.Request<Response>(url, this.API);
        }

        public Response Query(String UUID)
        {
            String url = String.Format("http://api.zeit.de/content/{0}?api_key={1}", UUID, this.API.APIKey);
            return APIRequester.Request<Response>(url, this.API);
        }

    }
}
