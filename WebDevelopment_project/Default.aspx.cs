using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace WebDevelopment_project
{
    public partial class _Default : Page
    {
        DataSet ds;
        DataTable dt;
        SqlDataAdapter sqlDataAdapter;
        SqlConnection con;
        String ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            messageboxred.Text = "";
            messagebox.Text = "";
        }
        private void DataBase_connection()
        {
            if (Environment.MachineName.ToString() == "RAHUL-HP-LAPTOP")
            {
                // localhost database string
                ConnectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                //Delopment database string
                ConnectionString = "Server=tcp:webdevservers.database.windows.net,1433;Initial Catalog=MasterSQL;Persist Security Info=False;User ID=Rahulsaini3125;Password= RahulSaini@in;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=3000000;";
            }
            con = new SqlConnection(ConnectionString);
            con.Open();
            sqlDataAdapter = new SqlDataAdapter("Select * from dbo.Userinfo", con);
            ds = new DataSet();
            dt = new DataTable();
            sqlDataAdapter.Fill(ds, "userinformation");
            dt = ds.Tables["userinformation"];
            try
            {
                String query = "INSERT INTO dbo.Userinfo (id,Email, Name, Password,Account_Create) VALUES ( @Id,@UserEmail, @UserName, @Userpassword, @AccountCreated)";
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Email"].ToString() == this.Email.Text)
                    {
                        throw new Exception("Email is Already Registrated");
                    }
                }
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserEmail", Email.Text);
                cmd.Parameters.AddWithValue("@Userpassword", password.Text);
                cmd.Parameters.AddWithValue("@UserName", Name.Text);
                Random rnd = new Random();
                int ID = rnd.Next();
                cmd.Parameters.AddWithValue("@ID", ID);
                DateTime ClientDateTime = DateTime.Now;
                DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(ClientDateTime, "India Standard Time");
                cmd.Parameters.AddWithValue("@AccountCreated",_localTime);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    messageboxred.Text = "";
                    messagebox.Text = "Your Data is Saved";
                    Response.AddHeader("REFRESH", "3;URL=login.aspx");
                }
                else { messagebox.Text = "Your Data is not Saved!"; }
            }
            catch (Exception ex)
            {
                messagebox.Text = "";
                messageboxred.Text = ex.Message;
            }
            finally
            {
                con.Dispose();
            }
        }
            protected void Button1_Click(object sender, EventArgs e)
        {
            DataBase_connection();
        }
    }
}