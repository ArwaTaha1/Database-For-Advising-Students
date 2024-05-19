using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arwa
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toRegisterPage(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void toLoginPage(object sender, EventArgs e)
        {
            Response.Redirect("Student_Login.aspx");
        }
    }
}