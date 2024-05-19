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
    public partial class spage5 : System.Web.UI.Page
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
                SqlCommand course = new SqlCommand("Procedures_AdminAddingCourse", conn);
                course.CommandType = CommandType.StoredProcedure;

                String major1 = major.Text;
                int semester1 = Int16.Parse(semester.Text);
                int credithours1 = Int16.Parse(credithours.Text);
                String coursename1 = coursename.Text;
                String offered1 = offered.Text;


                if (major.Text == "" || semester.Text == "" || credithours.Text == "" || coursename.Text == "" || offered.Text == "")
                {

                    Response.Write("One of the inputs is null");
                    return;
                }
                else
                {
                    course.Parameters.Add(new SqlParameter("@major", major1));
                    course.Parameters.Add(new SqlParameter("@semester", semester1));
                    course.Parameters.Add(new SqlParameter("@credit_hours", credithours1));
                    course.Parameters.Add(new SqlParameter("@name", coursename1));
                    course.Parameters.Add(new SqlParameter("@is_offered", offered1));
                    
                    conn.Open();
                    course.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("success");
                }



                
            }
            catch (Exception ex) 
            {
                Response.Write("wrong input format");  
            
            }
        }

    }
}


