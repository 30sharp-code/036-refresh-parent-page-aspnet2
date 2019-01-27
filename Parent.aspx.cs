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

public partial class Parent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            System.Configuration.ConfigurationManager.AppSettings["PageColor"] = "Red";
        }

        Style obj_Style = new Style();
        obj_Style.BackColor = System.Drawing.Color.FromName(System.Configuration.ConfigurationManager.AppSettings["PageColor"]);
        Panel1.ApplyStyle(obj_Style);
    }
}
