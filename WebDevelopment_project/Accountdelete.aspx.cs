using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls ;

namespace WebDevelopment_project
{
    public partial class Accountdelete : System.Web.UI.Page
    {
        SqlConnection connection;
        String ConnectionString;
        SqlCommand sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (Environment.MachineName.ToString() == "RAHUL-HP-LAPTOP")
            {
                // localhost database string
                ConnectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                //Delopment database string
                ConnectionString = "Data Source=tcp:webdevservers.database.windows.net,1433;Initial Catalog=MasterSQL;User Id=RahulSaini3125@webdevservers;Password=RahulSaini@in";
            }
            connection = new SqlConnection(ConnectionString);
        }

        protected void AccountDelete_Click(object sender, EventArgs e)
        {
            if (oldpassword.Text == Session["password"].ToString())
            {
                connection.Open();
                sql = new SqlCommand("delete from dbo.Userinfo where Id = @userid", connection);
                sql.Parameters.AddWithValue("@userid", Session["ID"]);
                sql.ExecuteNonQuery();
                connection.Dispose();
                messagebox.Text = "Account Delete";
                Session["ID"] = null;
                Session["Name"] = null;
                Session["AdminAccess"] = null;
                Session["Email"] = null;
                Session["Create_date"] = null;
                Session["password"] = null;
                Response.Redirect("login.aspx");
            }
            else
            {
                messageboxred.Text = "Wrong Passoword";
            }
        }
    }
}