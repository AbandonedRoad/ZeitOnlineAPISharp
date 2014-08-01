using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            String url = String.Format("http://api.zeit.de/content?api_key={0}", this.API.APIKey);
            return APIRequester.Request<Response>(url, this.API);
        }

        public Response Query(String UUID)
        {
            String url = String.Format("http://api.zeit.de/content/{0}?api_key={1}", UUID, this.API.APIKey);
            return APIRequester.Request<Response>(url, this.API);
        }

    }
}
