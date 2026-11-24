using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace project_ecommerce
{
    public partial class userreg : System.Web.UI.Page
    {
        insertion obj = new insertion();
        protected void Page_Load(object sender, EventArgs e)
        {




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = obj.insert_Fn(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text,  TextBox4.Text, TextBox5.Text,TextBox6.Text,TextBox7.Text);
            if (i == 1)
            {
                Label8.Text = "Inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginpage.aspx");

        }
    }
}

       




        
   
