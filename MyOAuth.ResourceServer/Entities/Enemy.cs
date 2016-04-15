using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.ResourceServer
{
    [Serializable]
    public class Enemy
    {
        public string UserId { get; set; }
        public string EnemyName { get; set; }

        public Enemy(string userid, string name)
        {
            UserId = userid;
            EnemyName = name;
        }
    }
}