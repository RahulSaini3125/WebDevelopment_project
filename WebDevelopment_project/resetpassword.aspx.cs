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
    public partial class resetpassword : System.Web.UI.Page
    {
        SqlConnection conn;
        String connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
            newpassdiv.Visible = false;
            messageboxred.Text = "";
            messagebox.Text = "";
            if (Environment.MachineName.ToString() == "RAHUL-HP-LAPTOP")
            {
                // localhost database string
                connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                //Delopment database string
                connectionString = "Data Source=tcp:webdevservers.database.windows.net,1433;Initial Catalog=MasterSQL;User Id=RahulSaini3125@webdevservers;Password=RahulSaini@in";
            }
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (Newpassword.Text == newpassword1.Text)
            {
                String cmd = "Update dbo.Userinfo  SET Password = @newpassword where Id = @userid ";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.AddWithValue("@newpassword", Newpassword.Text);
                command.Parameters.AddWithValue("@userid", Session["ID"]);
                int update = command.ExecuteNonQuery();
                if (update > 0)
                {
                    newpassdiv.Visible=true;
                    messagebox.Text = "Password Update Successfully";
                    Session["password"] = newpassword1.Text;
                    Response.AddHeader("REFRESH", "2;URL=ProfilePage.aspx");
                }
                else
                {
                    messageboxred.Text = "Try again after Sometime";
                }
            }
            else
            {
                messageboxred.Text = "Password Don't Match";
                newpassdiv.Visible=true;
            }
        }

        protected void verify_Click(object sender, EventArgs e)
        {
            if (oldpassword.Text == Session["password"].ToString())
            {
                oldpassdiv.Visible = false;
                newpassdiv.Visible = true;
            }
            else
            {
                messageboxred.Text = "Wrong Password";
            }
        }
    }
}