using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Child : System.Web.UI.Page
{
    protected void btn_ChangeColor_Click(object sender, EventArgs e)
    {
        System.Configuration.ConfigurationManager.AppSettings["PageColor"] = "Blue";
        string cRefreshParent = "<script language='javascript'>" + "  window.opener.document.forms(0).submit();" + "</script>";
        string cRefreshParentKey = "RefreshParentKey";
        if (!this.Page.ClientScript.IsClientScriptBlockRegistered(cRefreshParentKey))
        {
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
            cRefreshParentKey, cRefreshParent);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
