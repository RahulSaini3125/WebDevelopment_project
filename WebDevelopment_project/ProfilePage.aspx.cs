using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDevelopment_project
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
            Email.Text = Session["Email"].ToString();
            displayName.Text = Session["Name"].ToString();
            FullName.Text = Session["Name"].ToString();
            Id.Text = Session["Id"].ToString();
            Account_status.Text = Session["Status"].ToString();
            ACDT.Text = Session["Create_date"].ToString();
        }

        protected void Chnage_password_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("resetpassword.aspx");
        }

        protected void Delete_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Accountdelete.aspx");
        }
    }
}