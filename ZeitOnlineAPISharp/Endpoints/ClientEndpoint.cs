using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZeitOnlineAPISharp.Models.Client;

namespace ZeitOnlineAPISharp.Endpoints
{
    public class ClientEndpoint
    {

        protected API API {get; set;}

        public ClientEndpoint(API api) 
        {
            this.API = api;
        }

        public Response Query() 
        {
            String url = String.Format("http://api.zeit.de/client?api_key={0}", this.API.APIKey);
            return APIRequester.Request<Response>(url, this.API);
        }
    }
}
