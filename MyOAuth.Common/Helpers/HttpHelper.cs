using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.Text;

namespace MyOAuth.Common.Helpers
{
    public class HttpHelper
    {
        public static T GetRequest<T>(string url)
        {
            var client = new WebClient();
            var content = client.DownloadString(url);

            return DeserializeStr<T>(content);
        }

        //serializer.Serialize(p);
        public static T PostRequest<T>(string url, string jsonParams)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("Content-Type", "application/json");
            byte[] postData = Encoding.UTF8.GetBytes(jsonParams);
            byte[] responseData = wc.UploadData(url, "POST", postData);
            var content = Encoding.UTF8.GetString(responseData);
            return DeserializeStr<T>(content);
        }

        private static T DeserializeStr<T>(string content)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var t = serializer.Deserialize<T>(content);
            return t;
        }
    }
}