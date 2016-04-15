using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyOAuth.ResourceServer.Helpers;

namespace MyOAuth.ResourceServer.Svrs
{
    public class ResourceSvr : IResourceSvr
    {
        public User GetUser(string token)
        {
            var scope = "getuser";
            var userId = "";
            var isValid = AuthServerHelper.ValidTokenAndGetUserId(token, scope, ref userId);

            return isValid ? DB.GetUserResource(userId) : null;
        }

        public string GetFriend(string token)
        {
            var scope = "getfriend";
            var userId = "";
            var isValid = AuthServerHelper.ValidTokenAndGetUserId(token, scope, ref userId);

            return isValid ? DB.GetResource(userId, scope) : "";
        }

        public string GetEnemy(string token)
        {
            var scope = "getenemy";
            var userId = "";
            var isValid = AuthServerHelper.ValidTokenAndGetUserId(token, scope, ref userId);

            return isValid ? DB.GetResource(userId, scope) : "";
        }

        public string GetUserIdByLogin(string loginName, string pwd)
        {
            return DB.GetUserIdByLogin(loginName, pwd);
        }
    }
}