using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Advisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void View_Advising_Students(object sender, EventArgs e)
        {
            Response.Redirect("View_Advising_Students.aspx");

        }
        protected void Insert_graduation_plan(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Plan.aspx");

        }
        protected void Insert_courses_for_a_graduation_plan(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Course_Plan.aspx");

        }
        protected void Update_expected_graduation_date(object sender, EventArgs e)
        {
            Response.Redirect("Update_Plan.aspx");

        }
        protected void Delete_course_from_graduation_plan(object sender, EventArgs e)
        {
            Response.Redirect("Delete_Course_Plan.aspx");

        }
        protected void View_students_assigned_from_certain_major_with_their_courses(object sender, EventArgs e)
        {
            Response.Redirect("View_Students_Courses.aspx");

        }
        protected void View_all_requests(object sender, EventArgs e)
        {
            Response.Redirect("View_Requests.aspx");
        }
        protected void View_all_pending_requests(object sender, EventArgs e)
        {
            Response.Redirect("Pending_Requests.aspx");

        }
        protected void Approve_reject_extra_credit_hours_request(object sender, EventArgs e)
        {
            Response.Redirect("CH_Request.aspx");

        }
        protected void Approve_reject_extra_courses_request(object sender, EventArgs e)
        {
            Response.Redirect("Course_Request.aspx");

        }
    }
}
