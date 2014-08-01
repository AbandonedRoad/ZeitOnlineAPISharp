using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp
{
    public class HTMLRequester
    {



        protected static HttpWebRequest CreateWebRequest(String url)
        {

            HttpWebRequest webRequestObject = (HttpWebRequest)HttpWebRequest.Create(url);
            webRequestObject.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            webRequestObject.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            webRequestObject.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            webRequestObject.KeepAlive = false;
            webRequestObject.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1944.0 Safari/537.36";
            webRequestObject.Pipelined = true;
            webRequestObject.Timeout = 300000; // 300 seconds, default is 100 seconds
            return webRequestObject;
        }


        public static bool DownloadWebPage(String url, out String result, out HttpStatusCode statusCode)
        {
            HttpWebRequest webRequest = CreateWebRequest(url);
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            statusCode = response.StatusCode;
            try
            {
                using (Stream WebStream = response.GetResponseStream())
                {
                    using (StreamReader Reader = new StreamReader(WebStream, Encoding.UTF8))
                    {
                        result = Reader.ReadToEnd();
                        Reader.Close();
                        WebStream.Close();
                        response.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                result = String.Empty;
                return false;
            }
        }
    }
}
