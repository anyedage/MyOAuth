using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyOAuth.Client
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var userStr = Session["UserStr"];
                if (userStr != null && !string.IsNullOrEmpty(userStr.ToString()))
                    lit1.Text = userStr.ToString();
                else
                    lit1.Text = "未登陆";
            }
        }
    }
}