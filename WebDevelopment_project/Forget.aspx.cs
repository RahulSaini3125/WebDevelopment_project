using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDevelopment_project
{
    public partial class Forget : System.Web.UI.Page
    {
        SqlConnection conn;
        String connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
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
            otpdiv.Visible = false;
            homebtn.Visible = false;
            newpassdiv.Visible = false;
        }

        protected void Sendotp_Click(object sender, EventArgs e)
        {
            string to = emailID.Text; //To address    
            string from = "Dotnetreply@outlook.com"; //From address    
            MailMessage message = new MailMessage(from, to);
            Random random = new Random();
            Session["otp"] = random.Next(1000,10000);
            string mailbody = "Your Otp is" + Session["otp"];
            message.Subject = "Forget Password";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("Dotnetreply@outlook.com", "09876@1234");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
                messagebox.Text = "OTP Send Successfully";
                otpdiv.Visible=true;
                Sendotp.Visible=false;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void submitotp_Click(object sender, EventArgs e)
        {
            if (otptext.Text == Session["otp"].ToString())
            {
                messagebox.Text = "OTP Verify Successfully";
                emaildiv.Visible = false;
                otpdiv.Visible = false;
                newpassdiv.Visible = true;
            }
            else
            {
                messageboxred.Text = "OTP Is Wrong";
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (newpassword.Text == newpassword1.Text)
            {
                String cmd = "Update dbo.Userinfo  SET Password = @newpassword where Email = @userid ";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.AddWithValue("@newpassword", newpassword.Text);
                command.Parameters.AddWithValue("@userid", emailID.Text);
                int update = command.ExecuteNonQuery();
                if (update > 0)
                {
                    newpassdiv.Visible = true;
                    messagebox.Text = "Password Update Successfully";
                    newpassdiv.Visible=false;
                    homebtn.Visible = true;
                }
                else
                {
                    messageboxred.Text = "Try again after Sometime";
                }
            }
            else
            {
                messageboxred.Text = "Password Don't Match";
                newpassdiv.Visible = true;
            }
        }

        protected void homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}