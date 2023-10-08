using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;

namespace WebDevelopment_project
{
    public partial class Home_page : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null )
            {
                Response.Redirect("login.aspx");
            }
            Label2.Text = Session["AdminAccess"].ToString();
            Label1.Text = Session["Name"].ToString(); 
            conn = new SqlConnection("Server=tcp:webdevcu.database.windows.net,1433;Initial Catalog=WebDevelopmentDB;Persist Security Info=False;User ID=RahulSaini3125;Password=RahulSaini@in;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
            adapter = new SqlDataAdapter("Select * from dbo.Userinfo", conn);
            ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
        }

        protected void Show_data_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}