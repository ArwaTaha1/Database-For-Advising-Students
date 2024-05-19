using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Start1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Advisor(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Start.aspx");
        }
        protected void Admin(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void Student(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}