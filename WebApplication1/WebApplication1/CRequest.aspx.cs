using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arwa
{
    public partial class CRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand courseRequest = new SqlCommand("Procedures_StudentSendingCourseRequest", conn);
            courseRequest.CommandType = CommandType.StoredProcedure;
            string id = sID.Text;
            string cid = cID.Text;
            string t = type.Text;
            string c = comment.Text;

            if (id == "" || cid == "" || t == "" || c == "" )
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try {
                courseRequest.Parameters.Add(new SqlParameter("@courseID", cid));
                courseRequest.Parameters.Add(new SqlParameter("@StudentID", id));
                courseRequest.Parameters.Add(new SqlParameter("@type", t));
                courseRequest.Parameters.Add(new SqlParameter("@comment", c));

                conn.Open();
                courseRequest.ExecuteNonQuery();
                Response.Write("Success");
                conn.Close();
                }
                catch {
                    Response.Write("Student ID and Course ID must be integers");
                }
            }
        }
    }
}