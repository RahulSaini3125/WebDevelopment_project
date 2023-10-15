using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace WebDevelopment_project
{
    public partial class SiteMaster : MasterPage
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.Title != "Registrations" && Page.Title != "Login")
            {
                HiddenField1.Value = Session["AdminAccess"].ToString();
            }
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            Session["Name"] = null;
            Session["AdminAccess"] = null;
            Response.Redirect("login.aspx");
        }

        protected void Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminitration.aspx");
        }
    }
}