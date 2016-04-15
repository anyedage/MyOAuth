﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MyOAuth.AuthServer.Entities
{
    [DataContract]
    [Serializable]
    public class TokenRequest
    {
        public string code { get; set; }
        public string redirect_uri { get; set; }
        public string client_id { get; set; }
        public string grant_type { get; set; }
        public string client_secret { get; set; }
    }
}