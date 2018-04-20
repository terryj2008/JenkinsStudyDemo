using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class code : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Request.QueryString["openid"]))
        {
            Response.Redirect("http://mairuikeji.com/snsapi.aspx?state=" + HttpUtility.UrlEncode(Request.Url.AbsoluteUri));
        }
        else
        {
            Response.Write(Request.Url.AbsoluteUri);
        }
    }
}