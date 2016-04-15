using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.AuthServer.Entities
{
    public class TokenInfo
    {
        public string Token { get; set; }
        public string Scope { get; set; }
        public string UserId { get; set; }

        public TokenInfo(string token,string scope,string userId)
        {
            Token = token;
            Scope = scope;
            UserId = userId;
        }
    }
}