using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyOAuth.Client.Helpers;

namespace MyOAuth.Client
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["state"] == null)
                {
                    var state = Guid.NewGuid().ToString().Substring(0, 10);
                    lnkLogin.NavigateUrl = AuthServerHelper.AS_AuthUrl(Server.UrlEncode, state);
                }
                else
                {
                    var userStr = Bll.GetUserInfo(ViewState["state"].ToString());
                    if (!string.IsNullOrEmpty(userStr))
                    {
                        Session["UserStr"] = userStr;
                        Response.Redirect("Index.aspx");
                    }
                }
            }
        }
    }
}