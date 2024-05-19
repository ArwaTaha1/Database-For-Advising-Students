using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class Admins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeletedCourse.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeletedSlot.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("makeup.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("installments.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("status.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("active.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("gradplans.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("transcript.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("offeredcourses.aspx");
        }
    }
}