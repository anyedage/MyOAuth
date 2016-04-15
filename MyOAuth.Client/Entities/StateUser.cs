using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.Client
{
    public class StateUser
    {
        public string State { get; set; }
        public CUser User { get; set; }
        public bool HasUser { get; set; }
    }
}