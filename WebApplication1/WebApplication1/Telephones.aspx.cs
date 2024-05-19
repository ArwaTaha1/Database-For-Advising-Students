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
    public partial class Telephones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand studentAddPhone = new SqlCommand("Procedures_StudentaddMobile", conn);
            studentAddPhone.CommandType = CommandType.StoredProcedure;
            string id = sID.Text;
            string pn = phoneNumber.Text;
            if (id == "" || pn == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else { 
                try {
            studentAddPhone.Parameters.Add(new SqlParameter("@StudentID", id));
            studentAddPhone.Parameters.Add(new SqlParameter("@mobile_number", pn));
            conn.Open();
            studentAddPhone.ExecuteNonQuery();
            Response.Write("Success");
            conn.Close();
                }
                catch {
                    Response.Write("Student ID must be an integer");
                }
        }
        }
    }
}