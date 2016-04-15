using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.Client
{
    [Serializable]
    public class TokenResult
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
    }
}