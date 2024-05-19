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
using System.Xml.Linq;

namespace arwa
{
    public partial class CHRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand CHRequest = new SqlCommand("Procedures_StudentSendingCHRequest", conn);
            CHRequest.CommandType = CommandType.StoredProcedure;
            string id = sID.Text;
            string ch = CH.Text;
            string t = type.Text;
            string c = comment.Text;

            if (id == "" || ch == "" || t == "" || c == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try {
                CHRequest.Parameters.Add(new SqlParameter("@credit_hours", ch));
                CHRequest.Parameters.Add(new SqlParameter("@StudentID", id));
                CHRequest.Parameters.Add(new SqlParameter("@type", t));
                CHRequest.Parameters.Add(new SqlParameter("@comment", c));

                conn.Open();
                CHRequest.ExecuteNonQuery();
                Response.Write("Success");
                conn.Close();
                }
                catch {
                    Response.Write("Student ID and Credit Hours must be integers");
                }
            }
        }

        
    }
}