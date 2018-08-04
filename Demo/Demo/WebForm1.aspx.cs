using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        int a, b,sum;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //string b = TextBox1.Text;
            b = Convert.ToInt32(TextBox1.Text);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //string a = TextBox2.Text;
            a = Convert.ToInt32(TextBox1.Text);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            sum = a + b;
            Response.Write("Adding the numbers" + sum);
        }

    }
}