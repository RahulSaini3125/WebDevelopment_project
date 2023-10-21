using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;
using System.Reflection.Emit;
using Microsoft.Ajax.Utilities;

namespace WebDevelopment_project
{
    public partial class Home_page : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["ID"] == null )
            {
                Response.Redirect("login.aspx");
            }
            UserName.Text = Session["Name"].ToString();
            Label2.Text = Environment.MachineName.ToString();
        }
    }
}