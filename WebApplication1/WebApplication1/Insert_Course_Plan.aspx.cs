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
    public partial class Insert_Course_Plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void insert(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
                int sid = Int16.Parse(id.Text);
                string sem_code = sc.Text;
                string c_name = cn.Text;
                SqlCommand insert = new SqlCommand("Procedures_AdvisorAddCourseGP", conn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.Add(new SqlParameter("@student_id", sid));
                insert.Parameters.Add(new SqlParameter("@Semester_code", sem_code));
                insert.Parameters.Add(new SqlParameter("@course_name", c_name));
                conn.Open();
                insert.ExecuteNonQuery();
                conn.Close();
                Response.Write("Course Added To Graduation Plan Successfully!");

            }
            catch (System.FormatException)
            {
                Response.Write("Invalid Inputs, Please ReInput");
                return;

            }
            catch (Exception ex)
            {
                Response.Write("An error occurred: " + ex.Message);
                return;
            }
        }
    }
}