using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.Client
{
    public class StateCode
    {
        public string State { get; set; }
        public string Code { get; set; }
        public bool HasCode { get; set; }
    }
}