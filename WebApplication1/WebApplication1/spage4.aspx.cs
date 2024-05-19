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
    public partial class spage4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
        protected void page23(object sender, EventArgs e)
        {
            

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addsem = new SqlCommand("AdminAddingSemester", conn);
            addsem.CommandType = CommandType.StoredProcedure;

            String startdate = start.Text;
            String enddate = end.Text;
            String semestercode = code.Text;

            if (start.Text == "" || end.Text == "" || code.Text == "")
            {

                Response.Write("One of the inputs is null");
                return;
            }
            else
            {
                



                addsem.Parameters.Add(new SqlParameter("@start_date", startdate));
                addsem.Parameters.Add(new SqlParameter("@end_date", enddate));
                addsem.Parameters.Add(new SqlParameter("@semester_code", semestercode));
                try
                {
                    conn.Open();
                    addsem.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("success");
                }
                catch (Exception ex)
                {
                    Response.Write("duplicate primary key or wrong date format");
                }
            }



            
        }

    }
}