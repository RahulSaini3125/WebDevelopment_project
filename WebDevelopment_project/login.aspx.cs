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
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        DataTable dt;
        String connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            messageboxred.Text = "";
            if (Environment.MachineName.ToString() == "RAHUL-HP-LAPTOP")
            {
                // localhost database string
                connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                //Delopment database string
                connectionString = "Server=tcp:webdevservers.database.windows.net,1433;Initial Catalog=MasterSQL;Persist Security Info=False;User ID=Rahulsaini3125;Password= RahulSaini@in;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=3000000;";
            }
            conn = new SqlConnection(connectionString);
            String QuerySelect = "Select * from dbo.Userinfo";
            sqlDataAdapter = new SqlDataAdapter(QuerySelect, conn);
            ds = new DataSet();
            dt = new DataTable();
            sqlDataAdapter.Fill(ds, "userinfo");
            dt = ds.Tables["userinfo"];
            Session["dataset"] = ds;
            Session["datatable"] = dt;

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
                    cmd.Parameters.AddWithValue("@ID", dr["Id"].ToString());
                    cmd.ExecuteNonQuery();
                    if (dr["Account_Status"].ToString() == "False")
                    {
                        messageboxred.Text = "Your Account is Deactivate";
                    }
                    else 
                    {
                        Session["ID"] = dr["id"].ToString();
                        Session["Name"] = dr["Name"].ToString();
                        Session["AdminAccess"] = dr["AdminAccess"].ToString();
                        conn.Close();
                        Response.Redirect("Home_page.aspx");
                    }
                }
                else
                {
                    messageboxred.Text = "Login Failed!Username or Password is not correct";
                }
            }
        }
    }
}