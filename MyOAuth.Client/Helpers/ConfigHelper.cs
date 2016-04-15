using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MyOAuth.Client
{
    public class ConfigHelper
    {
        public static string CurrentClientDomain = ConfigurationManager.AppSettings["CurrentClientDomain"];
        public static string AuthServerDomain = ConfigurationManager.AppSettings["AuthServerDomain"];
        public static string ResourceServerDomain = ConfigurationManager.AppSettings["ResourceServerDomain"];
    }
}