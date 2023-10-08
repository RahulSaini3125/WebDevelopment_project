using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace WebDevelopment_project
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            messageboxred.Text = "";
            conn = new SqlConnection("Server=tcp:webdevcu.database.windows.net,1433;Initial Catalog=WebDevelopmentDB;Persist Security Info=False;User ID=RahulSaini3125;Password=RahulSaini@in;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
            adapter = new SqlDataAdapter("Select * from dbo.Userinfo", conn);
            ds = new DataSet();
            dt = new DataTable();
            adapter.Fill(ds, "userinformation");
            dt = ds.Tables["userinformation"];

            conn.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach ( DataRow dr  in dt.Rows )
            {
                if (dr["Email"].ToString() == this.Email.Text && dr["Password"].ToString() == this.password.Text)
                {
                    conn.Open();
                    String query = "Update dbo.Userinfo SET Lastlogin = @lastlogin Where id = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DateTime ClientDateTime = DateTime.Now;
                    DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(ClientDateTime, "India Standard Time");
                    cmd.Parameters.AddWithValue("@lastlogin", _localTime);
                    cmd.Parameters.AddWithValue("@ID", dr["id"].ToString());
                    cmd.ExecuteNonQuery();
                    Session["ID"] = dr["id"].ToString();
                    Session["Name"]= dr["Name"].ToString();
                    Session["AdminAccess"]= dr["AdminAccess"].ToString(); 
                    Response.Redirect("Home_page.aspx");
                }
                else
                {
                    messageboxred.Text = "Login Failed!Username or Password is not correct";
                }
            }
        }
    }
}