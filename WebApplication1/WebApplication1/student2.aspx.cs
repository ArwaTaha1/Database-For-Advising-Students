using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class student2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("selectwhattoview.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("1stor2ndME.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("chooseinstructor.aspx");
        }
    }
}