using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyOAuth.AuthServer.Entities;

namespace MyOAuth.AuthServer
{
    public class Bll
    {
        public static bool Valid_GetCodeReq(string clientId, string scope, string responseType, ref string errMsg)
        {
            var client = DB.GetClients().FirstOrDefault(x => x.ClientId == clientId);
            if(client == null)
            {
                errMsg="对不起，不存在此ClientId!";
                return false;
            }
            if(!client.Scopes.Exists(x=>x==scope))
            {
                errMsg= "对不起，此Client未注册" + scope + "服务!";
                return false;
            }
            if (responseType != "code")
            {
                errMsg= "对不起，目前只支持code方式的OAuth2.0!";
                return false;
            }
            return true;
        }

        public static bool Valid_GetTokenReq(string code, string clientId, string clientSecret, string grantType, ref string errMsg)
        {
            if (clientId != DB.GetClientId(code))
            {
                errMsg = "对不起，Code和ClientId不匹配!";
                return false;
            }
            if (null == DB.GetClients().FirstOrDefault(x => x.ClientId == clientId && x.ClientSecret == clientSecret))
            {
                errMsg = "对不起，ClientId和clientSecret不匹配!";
                return false;
            }
            if ("authorization_code" != grantType)
            {
                errMsg = "对不起，GrantType错误!";
                return false;
            }
            return true;
        }
        public static ValidAndGetUserIdResult ValidAndGetUserId(string token, string scope)
        {
            return DB.ValidTokenAndGetUserId(token, scope);
        }
        public static string CreateCode(string clientId, string scope, string userId)
        {
            return DB.CreateCode(clientId, scope, userId);
        }
        public static void CreateToken(string token, string scope, string userId)
        {
            DB.CreateToken(token, scope, userId);
        }
        public static string GetScopeDescription(string scope)
        {
            return ToScopeEnum(scope).Description();
        }
        public static string GetScopeByCode(string code)
        {
            return DB.GetScopeByCode(code);
        }
        public static string GetUserIdByCode(string code)
        {
            return DB.GetUserIdByCode(code);
        }
        public static string GetUserIdByToken(string token)
        {
            return DB.GetUserIdByToken(token);
        }
        public static string GetScopeByToken(string token)
        {
            return DB.GetScopeByToken(token);
        }
       
        private static ScopeEnum ToScopeEnum(string scope)
        {
            return (ScopeEnum)Enum.Parse(typeof(ScopeEnum), scope);
        }
    }
}