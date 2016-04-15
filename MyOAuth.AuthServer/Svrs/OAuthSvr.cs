using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyOAuth.AuthServer.Entities;

namespace MyOAuth.AuthServer.Svrs
{
    public class OAuthSvr : IOAuthSvr
    {
        public TokenResult Token(TokenRequest request)
        {
            var errMsg = "";
            if (!Bll.Valid_GetTokenReq(request.code, request.client_id, request.client_secret,request. grant_type, ref errMsg))
            {
                return new TokenResult("");
            }
            else
            {
                var token = Guid.NewGuid().ToString();
                var scope = Bll.GetScopeByCode(request.code);
                var userId = Bll.GetUserIdByCode(request.code);
                Bll.CreateToken(token, scope, userId);

                return new TokenResult(token);
            }
        }
    }
}