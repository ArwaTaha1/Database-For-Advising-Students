using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void studentstatus(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int id = Int16.Parse(TextBox1.Text);

                SqlCommand statusproc = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);
                statusproc.CommandType = CommandType.StoredProcedure;
                statusproc.Parameters.Add(new SqlParameter("@student_id", id));

                
                conn.Open();
                statusproc.ExecuteNonQuery();
                Response.Write(" Status updated successful");
                conn.Close();
            }
                catch (Exception ex)
                {
                    Response.Write("Error" + ex.Message);
                }
                
            }
            
            



        }
    }
