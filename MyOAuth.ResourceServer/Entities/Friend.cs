using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.ResourceServer
{
    [Serializable]
    public class Friend
    {
        public string UserId { get; set; }
        public string FriendName { get; set; }

        public Friend(string userid, string name)
        {
            UserId = userid;
            FriendName = name;
        }
    }
}