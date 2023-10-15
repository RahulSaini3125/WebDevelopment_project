using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDevelopment_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
            conn = new SqlConnection("Server=tcp:webdevcu.database.windows.net,1433;Initial Catalog=WebDevelopmentDB;Persist Security Info=False;User ID=RahulSaini3125;Password=RahulSaini@in;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
            adapter = new SqlDataAdapter("Select * from dbo.Userinfo", conn);
            ds = new DataSet();
            dt = new DataTable();
            adapter.Fill(ds, "userinformation");
            dt = ds.Tables["userinformation"];
            conn.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private void Gridview_Delete( object sender,GridViewDeletedEventArgs e) 
        {
           
        }
    }
}