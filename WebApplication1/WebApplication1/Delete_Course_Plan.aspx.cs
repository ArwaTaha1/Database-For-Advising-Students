using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Delete_Course_Plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Delete(object sender, EventArgs e)
        {
            try {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
           
                int student = Int16.Parse(sid.Text);
                int course = Int16.Parse(cid.Text);
                string sem_code = sc.Text;
                SqlCommand Delete = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
                Delete.CommandType = CommandType.StoredProcedure;
                Delete.Parameters.Add(new SqlParameter("@courseID", course));
                Delete.Parameters.Add(new SqlParameter("@studentID", student));
                Delete.Parameters.Add(new SqlParameter("@sem_code", sem_code));

                conn.Open();
                Delete.ExecuteNonQuery();
                conn.Close();
                Response.Write("Course Deleted Successfully!");
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