using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace ZeitOnlineAPISharp
{
    public class APIRequester
    {
        private static DateTime lastRequest {get;set;}

        public static T Request<T>(String url, API api) where T: class
        {
            if (api.LimitRate) 
            {
                while ((DateTime.Now - lastRequest).TotalMilliseconds < api.WaitPeriodMilliseconds) ;
            }

            String jsonResponse;
            HttpStatusCode statusCode;
            lastRequest = DateTime.Now;
            if (HTMLRequester.DownloadWebPage(url, out jsonResponse, out statusCode))
            {
                T response = JsonConvert.DeserializeObject<T>(jsonResponse);
                return response;
            }
            else
            {
                return null;
            }
        }
    }
}
