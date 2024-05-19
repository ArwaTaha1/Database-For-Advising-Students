using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Linq.Expressions;

namespace Advising_Team_7
{
    public partial class spage8 : System.Web.UI.Page
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
                SqlCommand course = new SqlCommand("Procedures_AdminLinkStudent", conn);
                course.CommandType = CommandType.StoredProcedure;

                int i = Int16.Parse(iid.Text);
                int s = Int16.Parse(sid.Text);
                int c = Int16.Parse(cid.Text);
                String sem = semm.Text;



                if (iid.Text == "" || sid.Text == "" || cid.Text == "" || semm.Text == "")
                {

                    Response.Write("One of the inputs is null");
                    return;
                }
                else
                {




                    course.Parameters.Add(new SqlParameter("@cours_id", c));
                    course.Parameters.Add(new SqlParameter("@instructor_id", i));
                    course.Parameters.Add(new SqlParameter("@studentID", s));
                    course.Parameters.Add(new SqlParameter("@semester_code", sem));

                    conn.Open();
                    course.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("success");
                }
            }
            catch (Exception ex)
            {
                Response.Write("course/instructor/student does not exist <br/>" +
                    "or choose a different course/instructor/student <br/>" +
                    "or wrong data format");
            }



            }




        }

       
    }
