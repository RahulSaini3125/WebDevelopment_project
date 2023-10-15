using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.EnterpriseServices.CompensatingResourceManager;

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
            Admin.Text = Session["AdminAccess"].ToString();
           selectalert.Visible = false;
           messagealertdone.Visible = false;
            messagealertundone.Visible = false;
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
        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            selectalert.Visible = true;
            foreach ( DataRow dr in dt.Rows)
            {
                if (dr["Id"].ToString() == GridView1.Rows[e.NewSelectedIndex].Cells[0].Text)
                {

                    User_id.Text = GridView1.Rows[e.NewSelectedIndex].Cells[0].Text;
                    UserName.Text = dr["Name"].ToString();
                    UserEmail.Text = dr["Email"].ToString();
                    UserACDT.Text = dr["Account_Create"].ToString();
                    UserLLDT.Text = dr["LastLogin"].ToString();
                }
            } 
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try 
            {
                SqlCommand sql = new SqlCommand("delete from dbo.Userinfo where Id = @userid", conn);
                sql.Parameters.AddWithValue("@userid", User_id.Text);
                sql.ExecuteNonQuery();
                selectalert.Visible = false;
                messagealertdone.Visible = true;
            }
            catch 
            {
                messagealertdone.Visible = false;
                messagealertundone.Visible = true;
            }
        }

        protected void Close_Click(object sender, EventArgs e)
        {
            selectalert.Visible = false;
        }
    }
}