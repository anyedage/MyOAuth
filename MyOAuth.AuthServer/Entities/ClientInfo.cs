using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.AuthServer.Entities
{
    public class ClientInfo
    {
        public string ClientId { get; set; }
        public string AppName { get; set; }
        public string ClientSecret { get; set; }
        public List<string> Scopes { get; set; }//client注册的授权scope

        public ClientInfo(string clientId, string appName, string clientSecret, List<string> scopes)
        {
            ClientId = clientId;
            AppName = appName;
            ClientSecret = clientSecret;
            Scopes = scopes;
        }
    }
}