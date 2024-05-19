using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class chooseinstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                int StudentID = Int16.Parse(id.Text);
                int courseID = Int16.Parse(id0.Text);
                String studentCurr_sem = id1.Text;
                int instrucorID = Int16.Parse(id2.Text);

                SqlCommand xx = new SqlCommand("Procedures_Chooseinstructor", conn);
                xx.CommandType = System.Data.CommandType.StoredProcedure;

                xx.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                xx.Parameters.Add(new SqlParameter("@courseID", courseID));
                xx.Parameters.Add(new SqlParameter("@studentCurr_sem", studentCurr_sem));
                xx.Parameters.Add(new SqlParameter("@instrucorID", instrucorID));

                conn.Open();
                Response.Write("Sucess");
                xx.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                Response.Write("Error");
            }
        }
    }
}