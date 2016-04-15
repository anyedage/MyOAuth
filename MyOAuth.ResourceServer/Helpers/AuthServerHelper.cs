using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.ResourceServer.Helpers
{
    public class AuthServerHelper
    {
        public static bool ValidTokenAndGetUserId(string token, string scope, ref string userId)
        {
            //获取token
            //var token_Params = Bll.AS_Token_Params(Server.UrlEncode, code);
            //var tokenResult = HttpHelper.PostRequest<TokenResult>(token_Params.Item1, token_Params.Item2);
                    
            return true;
        }
    }
}