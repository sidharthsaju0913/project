using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_ecommerce
{
    public partial class adminreg : System.Web.UI.Page
    {
        insertion obj = new insertion();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = obj.insert_fn(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            if (i == 1)
            {
                Label5.Text = "Inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginpage.aspx");
        }
    }
}