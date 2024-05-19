using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arwa
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_phone(object sender, EventArgs e)
        {

            Response.Redirect("Telephones.aspx");

        }

        protected void view_optional(object sender, EventArgs e)
        {
            Response.Redirect("Optional.aspx");
        }

        protected void view_all_courses(object sender, EventArgs e)
        {
            Response.Redirect("all.aspx");
        }

        protected void view_required(object sender, EventArgs e)
        {
            Response.Redirect("required.aspx");
        }

        protected void view_missing(object sender, EventArgs e)
        {
            Response.Redirect("missing.aspx");
        }

        protected void send_course_request(object sender, EventArgs e)
        {
            Response.Redirect("CRequest.aspx");
        }

        protected void send_CH_request(object sender, EventArgs e)
        {
            Response.Redirect("CHRequest.aspx");
        }
        protected void Next(object sender, EventArgs e)
        {

            Response.Redirect("student2.aspx");

        }
    }
    }
