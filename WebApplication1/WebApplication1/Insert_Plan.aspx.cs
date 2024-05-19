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
    public partial class Insert_Plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void insert(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
                int aid = Int16.Parse(id.Text);
                int student = Int16.Parse(sid.Text);
                DateTime selectedDate = Calendar1.SelectedDate;
                string sem_code = sc.Text;
                int sem_ch = Int16.Parse(sch.Text);
                SqlCommand insert = new SqlCommand("Procedures_AdvisorCreateGP", conn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.Add(new SqlParameter("@Semester_code", sem_code));
                insert.Parameters.Add(new SqlParameter("@expected_graduation_date", selectedDate));
                insert.Parameters.Add(new SqlParameter("@sem_credit_hours", sem_ch));
                insert.Parameters.Add(new SqlParameter("@advisor_id", aid));
                insert.Parameters.Add(new SqlParameter("@student_id", student));
                conn.Open();
                int rows = insert.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    Response.Write("Graduation Plan Inserted Successfully!");
                }
                else
                {
                    Response.Write("Student's acquired hours are not enough to insert a graduation plan for him/her");
                }
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