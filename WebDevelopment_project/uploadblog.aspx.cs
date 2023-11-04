using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDevelopment_project
{
    public partial class uploadblog : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand sql;
        String ConnectionString;
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
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            email.Text = Session["email"].ToString();
            email.Enabled = false;
            div1.Visible = false;
            div2.Visible = false;
            blogsubmit.Visible = false;
        }
        protected void blogsubmit_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO dbo.blog (Id, Title, Short_Content, Content, uploadby, uploaddatetime, uploadbyid, blogtype) VALUES (@id, @title, @short, @content, @upby, @updatetime, @uploadid, @blogtype)";
            sql = new SqlCommand(query, conn);
            sql.Parameters.AddWithValue("@title", Titles.Text);
            sql.Parameters.AddWithValue("@short", shortdes.Text);
            sql.Parameters.AddWithValue("@content", blogcon.Text);
            sql.Parameters.AddWithValue("@upby", Session["Name"].ToString());
            DateTime ClientDateTime = DateTime.Now;
            DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(ClientDateTime, "India Standard Time");
            sql.Parameters.AddWithValue("@updatetime", _localTime);
            sql.Parameters.AddWithValue("@uploadid", Session["ID"].ToString());
            Random random = new Random();
            sql.Parameters.AddWithValue("@id", random.Next());
            sql.Parameters.AddWithValue("@blogtype", blogtype.SelectedValue.ToString());
            int result = sql.ExecuteNonQuery();
            if (result > 0) 
            {
                messagebox.Text = "Your Blog is upload ";
            }
            else
            {
                messageboxred.Text = "Your Blog Could not upload by same reason. please Try again later";
            }
        }

        protected void blogtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            div1.Visible = true;
            div2.Visible = true;
            blogsubmit.Visible = true;
        }
    }
}