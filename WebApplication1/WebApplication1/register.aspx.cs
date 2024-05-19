using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebApplication1;

namespace arwa
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerStudent(object sender, EventArgs e)
        {

            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand studentRegisteration = new SqlCommand("Procedures_StudentRegistration", conn);
            studentRegisteration.CommandType = CommandType.StoredProcedure;
            string f = first_name.Text;
            string l = last_name.Text;
            string p = password.Text;
            string fa = faculty.Text;
            string em = email.Text;
            string m = major.Text;
            string s = (semester.Text);
            if (f == "" || l == "" || p == "" || fa == "" || em == "" || m == "" || s == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try {
                studentRegisteration.Parameters.Add(new SqlParameter("@first_name", f));
                studentRegisteration.Parameters.Add(new SqlParameter("@last_name", l));
                studentRegisteration.Parameters.Add(new SqlParameter("@password", p));
                studentRegisteration.Parameters.Add(new SqlParameter("@faculty", fa));
                studentRegisteration.Parameters.Add(new SqlParameter("@email", em));
                studentRegisteration.Parameters.Add(new SqlParameter("@major", m));
                studentRegisteration.Parameters.Add(new SqlParameter("@semester", s));

                SqlParameter success = studentRegisteration.Parameters.Add("@Student_id", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                studentRegisteration.ExecuteNonQuery();
                int studentId = Convert.ToInt32(success.Value);
                Response.Write("Success  ");
                conn.Close();
                Response.Write($"Student Added Successfully! Student ID: {studentId}");
                }
                catch(Exception ex) {
                    Response.Write("Error Occured: "+ ex.Message);
                }

               
            }

        }
    }
}