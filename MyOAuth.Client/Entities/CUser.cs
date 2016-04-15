using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.Client
{
    public class CUser
    {
        public string CUserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CUser(string cuserId, string name, int age)
        {
            CUserId = cuserId;
            Name = name;
            Age = age;
        }
    }
}