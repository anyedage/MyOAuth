using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyOAuth.Common.Helpers;
using MyOAuth.Client.Helpers;

namespace MyOAuth.Client
{
    public partial class Callback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string code = Request.QueryString["code"];
                string state = Request.QueryString["state"];
                //string grantType=Request.QueryString["grant_type"];

                //接收code
                if (!string.IsNullOrEmpty(code) && Bll.IsExistState(state))
                {
                    Bll.StorageCode(state, code);

                    //获取token
                    var token_Params = AuthServerHelper.AS_Token_Params(Server.UrlEncode, code);
                    var tokenResult = HttpHelper.PostRequest<TokenResult>(token_Params.Item1, token_Params.Item2);
                    if (string.IsNullOrEmpty(tokenResult.AccessToken))
                    {
                        var getUser_Params = AuthServerHelper.RS_GetUser_Params(tokenResult.AccessToken);
                        var user = HttpHelper.PostRequest<CUser>(getUser_Params.Item1, getUser_Params.Item2);
                        Bll.StorageUser(state, user);
                        Response.Write("获取User成功，请刷新登陆页面!");
                    }
                    else
                    {
                        Response.Write("获取Token失败，请重新申请授权!");
                    }
                }
            }
        }
    }
}