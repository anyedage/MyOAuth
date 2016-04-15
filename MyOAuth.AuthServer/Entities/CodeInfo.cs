using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.AuthServer.Entities
{
    public class CodeInfo
    {
        public string Code { get; set; }
        public string ClientId { get; set; }
        public string Scope { get; set; }
        public string UserId { get; set; }

        public CodeInfo(string code,string clientId,string scope,string userId)
        {
            Code = code;
            ClientId = clientId;
            Scope = scope;
            UserId = userId;
        }
    }
}