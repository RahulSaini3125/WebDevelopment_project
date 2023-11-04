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
    public partial class ProfilePage : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlCommand sql;
        String ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
            int totalpost = 0;
            Email.Text = Session["Email"].ToString();
            displayName.Text = Session["Name"].ToString();
            FullName.Text = Session["Name"].ToString();
            Id.Text = Session["Id"].ToString();
            Account_status.Text = Session["Status"].ToString();
            ACDT.Text = Session["Create_date"].ToString();

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
            adapter = new SqlDataAdapter("Select * from dbo.blog", conn);
            ds = new DataSet();
            dt = new DataTable();
            adapter.Fill(ds, "bloginformation");
            dt = ds.Tables["bloginformation"];

            Panel1.Controls.Add(new LiteralControl("<div class=\"row\">"));
            foreach (DataRow dr in dt.Rows)
            {
                if (Session["Id"].ToString() == dr["uploadbyid"].ToString())
                {

                    Label label = new Label();
                    Button btn = new Button();
                    btn.CssClass = "btn btn-primary";
                    btn.Text = "Read This Blog";
                    btn.CommandArgument = dr["Id"].ToString();
                    btn.ID = dr["Id"].ToString();
                    btn.Click += new EventHandler(read_btn);
                    Panel1.Controls.Add(new LiteralControl("<div class=\"col-lg-4 col-md-12 mb-4\">\r\n" +
                    "<div class=\"card\">\r\n" +
                    "<div class=\"bg-image hover-overlay ripple\" data-mdb-ripple-color=\"light\">\r\n" +
                    "<img src=\"https://mdbootstrap.com/img/new/standard/nature/184.jpg\" class=\"img-fluid\" />\r\n" +
                    "<a href=\"#!\">\r\n" +
                    "<div class=\"mask\" style=\"background-color: rgba(251, 251, 251, 0.15);\"></div>\r\n" +
                    "</a>\r\n" +
                    "</div>\r\n" +
                    "<div class=\"card-body\">\r\n" +
                    "<h5 class=\"card-title\">" + dr["Title"] + "</h5>\r\n" +
                    "<p class=\"card-text\">\r\n " + dr["Short_Content"] + "\r\n</p>\r\n" +
                    "<label class=\"card-names\">Upload By: " + dr["uploadby"] + "</label>\r\n"));
                    Panel1.Controls.Add(btn);
                    Panel1.Controls.Add(new LiteralControl("</div>\r\n" +
                    "</div>\r\n " +
                    "</div>"));
                    totalpost++;
                }
            }
            Totalpost.Text = totalpost.ToString();
        }

        protected void Chnage_password_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("resetpassword.aspx");
        }

        protected void Delete_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Accountdelete.aspx");
        }
        protected void read_btn(object sender, EventArgs e)
         {
                Session["ReadID"] = null;
                string val = ((Button)sender).CommandArgument.ToString();
                Session["ReadID"] = val;
                Response.Redirect("blogread.aspx");
         }

        protected void ownblog_Click(object sender, EventArgs e)
        {
            Response.Redirect("uploadblog.aspx");
        }
    }
}