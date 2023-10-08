using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDevelopment_project
{
    public partial class Calculator : System.Web.UI.Page
    {
        static int a, b = 0;
        static char d;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void one_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += one.Text;
            }
            else
            {
                Screen.Text += one.Text;
            }

        }

        protected void two_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += two.Text;
            }
            else
            {
                Screen.Text += two.Text;
            }
        }

        protected void three_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += three.Text;
            }
            else
            {
                Screen.Text += three.Text;
            }
        }

        protected void four_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += four.Text;
            }
            else
            {
                Screen.Text += four.Text;
            }
        }

        protected void five_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += five.Text;
            }
            else
            {
                Screen.Text += five.Text;
            }
        }

        protected void six_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += six.Text;
            }
            else
            {
                Screen.Text += six.Text;
            }
        }

        protected void seven_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += seven.Text;
            }
            else
            {
                Screen.Text += seven.Text;
            }
        }

        protected void eigth_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += eigth.Text;
            }
            else
            {
                Screen.Text += eigth.Text;
            }
        }

        protected void nine_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += nine.Text;
            }
            else
            {
                Screen.Text += nine.Text;
            }
        }

        protected void zero_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += zero.Text;
            }
            else
            {
                Screen.Text += zero.Text;
            }
        }

        protected void plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(Screen.Text);
            b = (b + a);
            d = '+';
            Screen.Text = "";
            TextBox1.Text = "+";

        }

        protected void minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(Screen.Text);
            if (b == 0)
            {
                b = a;
            }
            else
            {
                b = (b - a);
            }
            d = '-';
            Screen.Text = "";
            TextBox1.Text = "-";

        }

        protected void mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(Screen.Text);
            if (b == 0)
            {
                b = a;
            }
            else
            {
                b = (a * b);
            }
            d = '*';
            Screen.Text = "";
            TextBox1.Text = "*";
        }

        protected void div_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(Screen.Text);
            if (b == 0)
            {
                b = a;
            }
            else
            {
                b = (a / b);
            }
            d = '/';
            Screen.Text = "";
            TextBox1.Text = "/";
        }

        protected void dot_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "+" || Screen.Text == "-" || Screen.Text == "*" || Screen.Text == "/")
            {
                Screen.Text = "";
                Screen.Text += dot.Text;
            }
            else
            {
                Screen.Text += dot.Text;
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            TextBox1.Text = "";
            a = b = 0;
        }

        protected void equal_Click(object sender, EventArgs e)
        {
            if (d == '+')
            {
                a = Convert.ToInt32(Screen.Text);
                b = (b + a);
                Screen.Text = "";
                Screen.Text += b;
            }
            else if (d == '-')
            {
                a = Convert.ToInt32(Screen.Text);
                b = (b - a);
                Screen.Text = "";
                Screen.Text += b;
            }
            else if (d == '*')
            {
                a = Convert.ToInt32(Screen.Text);
                b = (b * a);
                Screen.Text = "";
                Screen.Text += b;
            }
            else if (d == '/')
            {
                a = Convert.ToInt32(Screen.Text);
                b = (b / a);
                Screen.Text = "";
                Screen.Text += b;
            }
            TextBox1.Text = "";
        }
    }
}