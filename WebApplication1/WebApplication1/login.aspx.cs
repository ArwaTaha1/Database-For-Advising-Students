using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_7
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void page1(object sender, EventArgs e)
        {
            if (Username.Text == "1" && Password.Text == "zeina")
            {

                Response.Redirect("admin.aspx");
            }
            else
            {
                Response.Write("wrong username or password");
            }
        }
    }
}