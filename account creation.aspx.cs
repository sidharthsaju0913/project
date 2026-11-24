using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_ecommerce
{
    public partial class account_creation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminreg.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userreg.aspx");
        }
    }
}