﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Diagnostics;

namespace WebDevelopment_project
{
    public partial class WebForm1 : System.Web.UI.Page
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
            Admin.Text = Session["AdminAccess"].ToString();
           selectalert.Visible = false;
           messagealertdone.Visible = false;
            messagealertundone.Visible = false;
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
            conn = new SqlConnection(ConnectionString);
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
                    useradmin.Text = dr["AdminAccess"].ToString();
                    if (dr["Account_Status"].ToString() == "True")
                    {
                        UserStatus.Text = "Activate";
                    }
                    else
                    {
                        UserStatus.Text = "Deactivate";
                    }
                }
            } 
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try 
            {
                sql = new SqlCommand("delete from dbo.Userinfo where Id = @userid", conn);
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

        protected void Deactivate_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Query_deactivate = "Update dbo.Userinfo  SET Account_Status = 0 where Id = @userid ";
            sql = new SqlCommand(Query_deactivate, conn);
            sql.Parameters.AddWithValue("@userid", User_id.Text);
            sql.ExecuteNonQuery();
            messagealertdone.Visible = true;
        }

        protected void activate_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Query_deactivate = "Update dbo.Userinfo  SET Account_Status = 1 where Id = @userid ";
            sql = new SqlCommand(Query_deactivate, conn);
            sql.Parameters.AddWithValue("@userid", User_id.Text);
            sql.ExecuteNonQuery();
            messagealertdone.Visible = true;
        }
    }
}