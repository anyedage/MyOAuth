using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyOAuth.AuthServer
{
    public partial class Auth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var clientId = Request.QueryString["client_id"];
                var responseType = Request.QueryString["response_type"];
                var scope = Request.QueryString["scope"];

                var errMsg = "";
                if (!Bll.Valid_GetCodeReq(clientId, scope, responseType, ref errMsg))
                {
                    litContent.Text = errMsg;
                }
                else
                {
                    litContent.Text = Bll.GetScopeDescription(scope);
                }
            }
        }

        protected void btnAuth_Click(object sender, EventArgs e)
        {
            var clientId = Request.QueryString["client_id"];
            var redirectUri = Request.QueryString["redirect_uri"];
            var state = Request.QueryString["state"];
            var scope = Request.QueryString["scope"];

            //判断账号密码正确性
            var loginId = ResourceServerHelper.GetUserIdByLogin(txtUser.Text, txtPwd.Text);
            if (string.IsNullOrEmpty(loginId))
            {
                var code = Bll.CreateCode(clientId, scope, loginId);
                Response.Redirect(string.Format("{0}?code={1}&state={2}", redirectUri, code, state));
            }
            else
                litAuthResult.Text = "登录失败！";
        }
    }
}