using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.ResourceServer
{
    [Serializable]
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public User(string userId, string name, string loginName, string pwd, int age)
        {
            UserId = userId;
            Name = name;
            LoginName = loginName;
            Password = pwd;
            Age = age;
        }
    }
}