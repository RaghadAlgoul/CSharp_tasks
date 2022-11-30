using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
        
    {
        int x = 0;
        int y = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sum_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = x + y;
            Label3.Text= z.ToString();

             

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = x - y;
            Label3.Text = z.ToString();
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = x * y;
            Label3.Text = z.ToString();
        }

        protected void div_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = x / y;
            Label3.Text = z.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}