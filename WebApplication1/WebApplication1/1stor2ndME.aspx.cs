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
    public partial class _1stor2ndME : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int StudentID = Int16.Parse(StudentId.Text);
                int courseID = Int16.Parse(CourseId.Text);
                String studentCurr_sem = Currentsem.Text;
                SqlCommand sM = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn);
                sM.CommandType = CommandType.StoredProcedure;
                sM.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                sM.Parameters.Add(new SqlParameter("@courseID", courseID));
                sM.Parameters.Add(new SqlParameter("@studentCurr_sem", studentCurr_sem));

                conn.Open();
                Response.Write("success");
                sM.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Response.Write("Error");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int StudentID = Int16.Parse(StudentId.Text);
                int courseID = Int16.Parse(CourseId.Text);
                String studentCurr_sem = Currentsem.Text;
                SqlCommand FM = new SqlCommand("Procedures_StudentRegisterSecondMakeup", conn);
                FM.CommandType = CommandType.StoredProcedure;
                FM.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                FM.Parameters.Add(new SqlParameter("@courseID", courseID));
                FM.Parameters.Add(new SqlParameter("@studentCurr_sem", studentCurr_sem));

                conn.Open();
                Response.Write("success");
                FM.ExecuteNonQuery();
                conn.Close();
              }
            catch
            {
                Response.Write("Error");
            }

            }
           
        }

        
    }
