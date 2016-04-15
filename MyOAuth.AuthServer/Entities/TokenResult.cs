using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MyOAuth.AuthServer.Entities
{
    [Serializable]
    [DataContract]
    public class TokenResult
    {
        [DataMember]
        public string AccessToken { get; set; }
        [DataMember]
        public string TokenType { get; set; }
        [DataMember]
        public int ExpiresIn { get; set; }

        public TokenResult(string token)
        {
            AccessToken = token; TokenType = "Bearer"; ExpiresIn = 3600;
        }
    }
}