using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDevelopment_project
{
    public partial class blogread : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dt = (DataTable)Session["Dt"];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Id"].ToString() == Session["ReadID"].ToString())
                {
                    Titles.Text = dr["Title"].ToString();
                    Shortdes.Text = dr["Short_Content"].ToString();
                    blog.Text = dr["Content"].ToString();
                    upload.Text = dr["uploadby"].ToString();
                    datetime.Text = dr["uploaddatetime"].ToString();
                }
            }
        }
    }
}