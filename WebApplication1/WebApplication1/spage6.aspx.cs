using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_7
{
    public partial class spage6 : System.Web.UI.Page
    {
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void page23(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand course = new SqlCommand("Procedures_AdminLinkInstructor", conn);
                course.CommandType = CommandType.StoredProcedure;

                int i = Int16.Parse(iid.Text);
                int s = Int16.Parse(sid.Text);
                int ss = Int16.Parse(slid.Text);

                if (iid.Text == "" || sid.Text == "" || slid.Text == "")
                {

                    Response.Write("One of the inputs is null");
                    return;
                }
                else
                {
                    course.Parameters.Add(new SqlParameter("@instructor_id", i));
                    course.Parameters.Add(new SqlParameter("@cours_id", s));
                    course.Parameters.Add(new SqlParameter("@slot_id", ss));
                    conn.Open();
                    course.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("success");

                }
            }
            catch (Exception ex)
            {
                    Response.Write("wrong data format or the insturctor or course do not exist");
            }
            



            

        }


    }
}