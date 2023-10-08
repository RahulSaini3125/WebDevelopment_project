using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebDevelopment_project
{
    public partial class SiteMaster : MasterPage
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            Session["Name"] = null;
            Session["AdminAccess"] = null;
            Response.Redirect("login.aspx");
        }
    }
}