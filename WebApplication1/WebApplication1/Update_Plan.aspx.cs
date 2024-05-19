using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Update_Plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Insert(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
           
                int student = Int16.Parse(sid.Text);
                DateTime selectedDate = Calendar1.SelectedDate;
                SqlCommand Insert = new SqlCommand("Procedures_AdvisorUpdateGP", conn);
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.Add(new SqlParameter("@expected_grad_date", selectedDate));
                Insert.Parameters.Add(new SqlParameter("@studentID", student));
                conn.Open();
                Insert.ExecuteNonQuery();
                conn.Close();
                Response.Write("Graduation Plan Updated Successfully!");

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