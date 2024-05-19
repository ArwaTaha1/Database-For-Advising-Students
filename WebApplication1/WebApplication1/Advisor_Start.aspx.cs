using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Login.aspx");

        }
        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Registration.aspx");

        }
    }
}