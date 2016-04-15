using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MyOAuth.Client
{
    public class Bll
    {
        private static List<StateCode> stateCodes = new List<StateCode>();
        private static List<StateUser> stateUsers = new List<StateUser>();

        public static string RedirectUri { get { return ConfigHelper.CurrentClientDomain + "Forms/Callback.aspx"; } }
        public static string ClientId { get { return "client1"; } }
        public static string ClientSecret { get { return "secret1"; } }
        public static string ResponseType { get { return "code"; } }
        public static string GrantType { get { return "authorization_code"; } }
        
        public static void AddStateCode(StateCode stateCode)
        {
            stateCodes.Add(stateCode);
        }
        public static bool HasCode(string state)
        {
            var stateCode = stateCodes.FirstOrDefault(x => x.State == state);
            return stateCode.HasCode;
        }
        public static string GetUserInfo(string state)
        {
            var stateUser = stateUsers.FirstOrDefault(x => x.State == state);
            return stateUser.HasUser?string.Format("姓名：{0}，年龄：{1}",stateUser.User.Name,stateUser.User.Age):"";
        }

        public static bool IsExistState(string state)
        {
            var stateCode = stateCodes.FirstOrDefault(x => x.State == state);
            return stateCode != null;
        }

        public static void StorageCode(string state, string code)
        {
            var stateCode = stateCodes.FirstOrDefault(x => x.State == state);
            stateCode.Code = code;
            stateCode.HasCode = true;
        }

        public static void StorageUser(string state, CUser user)
        {
            var stateUser = new StateUser { State = state, User = user, HasUser = true };
            stateUsers.Add(stateUser);
        }
    }
}