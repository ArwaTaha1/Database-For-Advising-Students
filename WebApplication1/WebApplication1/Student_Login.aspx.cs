using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arwa
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ToHomePage(object sender, EventArgs e)
        {

            Boolean output;
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_ID, @password)", conn);
            string sID = ID.Text;
            string p = password.Text;

            try {
            cmd.Parameters.AddWithValue("@Student_id", sID);
            cmd.Parameters.AddWithValue("@password", p);
            conn.Open();
            output = (Boolean)cmd.ExecuteScalar();
                if (output == true)
                {


                    Response.Write("Sucsess");
                    Response.Redirect("HomePage.aspx");


                }

                else
                {
                    Response.Write("Try Again");
                    return;
                }

                conn.Close();
            }
            catch {
                Response.Write("Student ID must be an integer");
            }

            

           



        }
    }
}