using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;

namespace WebDevelopment_project
{
    public partial class Contactus : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
            username.Text = Session["Name"].ToString();
            useremail.Text = Session["email"].ToString();
        }

        protected void Send_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            String pathxml = "dataxml.xml";
            xmlDocument.Load(Server.MapPath(pathxml));
            XmlElement feedback = xmlDocument.CreateElement("Feedback_Details");
            XmlElement name = xmlDocument.CreateElement("Name");
            name.InnerText = username.Text;
            XmlElement email = xmlDocument.CreateElement("Email");
            email.InnerText = useremail.Text;
            XmlElement subject = xmlDocument.CreateElement("Subject");
            subject.InnerText = usersubject.Text;
            XmlElement message = xmlDocument.CreateElement("Message");
            message.InnerText = usermessage.Text;
            feedback.AppendChild(name);
            feedback.AppendChild(email);
            feedback.AppendChild(subject);
            feedback.AppendChild(message);
            xmlDocument.DocumentElement.AppendChild(feedback);
            xmlDocument.Save(Server.MapPath(pathxml));
            messagebox.Text = "Success!";
            usersubject.Text = string.Empty;
            usermessage.Text = string.Empty;
        }
    }
}