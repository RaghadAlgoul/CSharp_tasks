using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30_Nov
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void num1_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "1";     }

        protected void num2_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "2";
        }

        protected void num3_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "3";
        }

        protected void num4_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "4";
        }

        protected void num5_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "5";
        }

        protected void num6_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "6";
        }

        protected void num7_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "7";
        }

        protected void num8_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "8";
        }

        protected void num9_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore + "9";
        }
        float num;
        int count;
        protected void sum_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                string x = textstore.Text.Substring(31);
                num = float.Parse(x);
                result.Text = textstore.Text + "+";
                textstore.Text = "";
                count = 1;
            }
            
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                string x = textstore.Text.Substring(31);
                num = float.Parse(x);
                result.Text = textstore.Text + "-";
                textstore.Text = "";
                count = 2;
            }
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                string x = textstore.Text.Substring(31);
                num = float.Parse(x);
                result.Text = textstore.Text + "*";
                textstore.Text = "";
                count = 3;
            }
        }

        protected void div_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                string x = textstore.Text.Substring(31);
                num = float.Parse(x);
                result.Text = textstore.Text + "/";
                textstore.Text = "";
                count = 4;
            }
        }

        protected void equal_Click(object sender, EventArgs e)
        {

            float ans;
            string x = textstore.Text.Substring(31);
            if (count == 0)
            {
                ans = num + float.Parse(x);
                result.Text = result.Text + x + "=" + ans;
                textstore.Text = ans.ToString();

            }
            else if (count == 2)
            {
                ans = num - float.Parse(x);
                result.Text = result.Text +  x + "=" + ans;
                textstore.Text = ans.ToString();
            }
            //switch (count) { 
            // case 1 : 

            //}

        }
    }
}