using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MyOAuth.Client.Helpers
{
    public class AuthServerHelper
    {
        private static string AS_AuthFormatUrl =
           ConfigHelper.AuthServerDomain + "Forms/Auth.aspx?redirect_uri={0}&client_id={1}&state={2}&response_type={3}&scope={4}";
        private static string AS_TokenSvrUrl =
            ConfigHelper.AuthServerDomain + "OAuthSvr.svc/Token";
        private static string RS_ResourceSvrUrl =
            ConfigHelper.ResourceServerDomain + "ResourceSvr.svr/GetUser";

        public static string AS_AuthUrl(Func<string, string> urlEncode, string state)
        {
            var stateCode = new StateCode { State = state, Code = "", HasCode = false };
            Bll.AddStateCode(stateCode);
            var scope = "getuser";
            return string.Format(AS_AuthFormatUrl, urlEncode(Bll.RedirectUri), Bll.ClientId, stateCode.State, Bll.ResponseType, scope);
        }
        public static Tuple<string, string> AS_Token_Params(Func<string, string> urlEncode, string code)
        {
            var p = new { code = code, redirect_uri = urlEncode(Bll.RedirectUri), client_id = Bll.ClientId, grant_type = Bll.GrantType, client_secret = Bll.ClientSecret };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(p);
            return new Tuple<string, string>(AS_TokenSvrUrl, json);
        }
        public static Tuple<string, string> RS_GetUser_Params(string token)
        {
            var p = new { token = token };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(p);
            return new Tuple<string, string>(RS_ResourceSvrUrl, json);
        }
    }
}