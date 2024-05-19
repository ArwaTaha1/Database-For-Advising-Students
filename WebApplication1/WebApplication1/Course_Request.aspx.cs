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
    public partial class Course_Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void insert(object sender, EventArgs e)
        {
            try {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
                int rid = Int16.Parse(id.Text);
                string sem_code = sc.Text;
                SqlCommand insert = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", conn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.Add(new SqlParameter("@requestID", rid));
                insert.Parameters.Add(new SqlParameter("@current_semester_code", sem_code));
                conn.Open();
                insert.ExecuteNonQuery();
                conn.Close();
                Response.Write("Updated Successfully!");
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