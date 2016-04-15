using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.AuthServer.Entities
{
    [Serializable]
    public class ValidAndGetUserIdResult
    {
        public bool IsValid { get; set; }
        public string UserId { get; set; }
    }
}