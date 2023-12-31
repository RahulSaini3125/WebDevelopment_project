﻿using System;
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
                connectionString = "Data Source=tcp:webdevservers.database.windows.net,1433;Initial Catalog=MasterSQL;User Id=RahulSaini3125@webdevservers;Password=RahulSaini@in";
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
                    if (dr["Account_Status"].ToString() == "False")
                    {
                        messageboxred.Text = "Your Account is Deactivate";
                    }
                    else 
                    {
                        conn.Open();
                        String query = "Update dbo.Userinfo SET Lastlogin = @lastlogin Where id = @ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        DateTime ClientDateTime = DateTime.Now;
                        DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(ClientDateTime, "India Standard Time");
                        cmd.Parameters.AddWithValue("@lastlogin", _localTime);
                        cmd.Parameters.AddWithValue("@ID", dr["Id"].ToString());
                        cmd.ExecuteNonQuery();
                        Session["ID"] = dr["id"].ToString();
                        Session["Name"] = dr["Name"].ToString();
                        Session["AdminAccess"] = dr["AdminAccess"].ToString();
                        Session["Email"] = dr["Email"].ToString();
                        Session["Create_date"] = dr["Account_Create"].ToString();
                        Session["password"] = dr["Password"].ToString();
                        if (dr["Account_Status"].ToString() == "True")
                        {
                            Session["Status"] = "Activate";
                        }
                        else
                        {
                            Session["Status"] = "Deactivate";
                        }
                        
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