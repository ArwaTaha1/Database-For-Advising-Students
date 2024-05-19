using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class selectwhattoview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Graduation plan.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("unpaid installment.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("courses and exams details.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses and slots and details.aspx");
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("certain instrusctor and Course.aspx");
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("course and its prerequisites.aspx");
        }
    }
}