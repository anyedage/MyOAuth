using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyOAuth.AuthServer.Entities;

namespace MyOAuth.AuthServer
{
    public class DB
    {
        private static List<ClientInfo> clients;
        private static List<CodeInfo> codes = new List<CodeInfo>();
        private static List<TokenInfo> tokens = new List<TokenInfo>();

        static DB()
        {
            clients = new List<ClientInfo>
            {
                new ClientInfo("client1","应用1", "secret1", new List<string>{"getuser","getfriend"}),
                new ClientInfo("client2", "应用2","secret2", new List<string>{"getuser","getenemy"}),
                new ClientInfo("client3", "应用3","secret3", new List<string>{"getuser","getfriend","getenemy"})
            };
        }

        public static List<ClientInfo> GetClients()
        {
            return clients;
        }
        public static string CreateCode(string clientId, string scope, string userId)
        {
            var code = Guid.NewGuid().ToString();
            codes.Add(new CodeInfo(code, clientId, scope, userId));
            return code;
        }
        public static void CreateToken(string token, string scope, string userId)
        {
            tokens.Add(new TokenInfo(token, userId, scope));
        }
        public static string GetClientId(string code)
        {
            var codeInfo = GetCodeInfo(code);
            return codeInfo == null ? "" : codeInfo.ClientId;
        }
        public static string GetScopeByCode(string code)
        {
            var codeInfo = GetCodeInfo(code);
            return codeInfo == null ? "" : codeInfo.Scope;
        }
        public static string GetUserIdByCode(string code)
        {
            var codeInfo = GetCodeInfo(code);
            return codeInfo == null ? "" : codeInfo.UserId;
        }
        public static string GetUserIdByToken(string token)
        {
            var tokenInfo = GetTokenInfo(token);
            return tokenInfo == null ? "" : tokenInfo.UserId;
        }
        public static string GetScopeByToken(string token)
        {
            var tokenInfo = GetTokenInfo(token);
            return tokenInfo == null ? "" : tokenInfo.Scope;
        }
        public static ValidAndGetUserIdResult ValidTokenAndGetUserId(string token, string scope)
        {
            var isValid = false;
            var userId = "";
            var tokenInfo = GetTokenInfo(token);
            if (tokenInfo != null && tokenInfo.Scope == scope)
            {
                userId = tokenInfo.UserId;
                isValid = true;
            }
            return new ValidAndGetUserIdResult { IsValid = isValid, UserId = userId };
        }

        private static CodeInfo GetCodeInfo(string code)
        {
            var gCode = new Guid(code);
            return codes.FirstOrDefault(x => x.Code == code);
        }
        private static TokenInfo GetTokenInfo(string token)
        {
            return tokens.FirstOrDefault(x => x.Token == token);
        }
    }
}