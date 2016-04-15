using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.ResourceServer
{
    public class DB
    {
        private static List<User> users;
        private static List<Friend> friends;
        private static List<Enemy> enemies;

        static DB()
        {
            users = new List<User>      
            {        
                new User("user1", "张无忌","zhangwuji", "1", 23),
                new User("user2", "杨过", "yangguo","2", 36)
            };
            friends = new List<Friend>     
            {        
                new Friend("user1", "赵敏"),
                new Friend("user1", "小龙女")
            };
            enemies = new List<Enemy>     
            {           
                new Enemy("user1", "成昆"),
                new Enemy("user1", "金轮法王") 
            };
        }
        public static string GetUserIdByLogin(string loginName, string pwd)
        {
            var user = users.FirstOrDefault(x => x.LoginName == loginName && x.Password == pwd);
            return user == null ? "" : user.UserId;
        }
        public static User GetUserResource(string userId)
        {
            return users.FirstOrDefault(x => x.UserId == userId);
        }
        public static string GetResource(string userId, string scope)
        {
            var result = "";
            switch (scope)
            {
                //case "getuser":
                    //var user = users.FirstOrDefault(x => x.UserId == userId);
                    //result = user == null ? "" : string.Format("用户姓名：{0},年龄：{1}", user.Name, user.Age);
                    //break;
                case "getfriend":
                    var friend = friends.FirstOrDefault(x => x.UserId == userId);
                    result = friend == null ? "" : friend.FriendName;
                    break;
                case "getenemy":
                    var enemy = enemies.FirstOrDefault(x => x.UserId == userId);
                    result = enemy == null ? "" : enemy.EnemyName;
                    break;
                default:
                    throw new Exception("scope类型错误");
            }
            return result;
        }
    }
}