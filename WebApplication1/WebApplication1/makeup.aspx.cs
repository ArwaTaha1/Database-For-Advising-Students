using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;


namespace project
{
    public partial class makeup1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void makeupexaminsertion(object sender, EventArgs e)
        {
            try
            {

                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                string types = DropDownList1.Text;
                DateTime dates = Calendar1.SelectedDate;
                int id = Int16.Parse(TextBox3.Text);
                SqlCommand makeupproc = new SqlCommand("Procedures_AdminAddExam", conn);
                makeupproc.CommandType = CommandType.StoredProcedure;
                makeupproc.Parameters.Add(new SqlParameter("@Type", types));
                makeupproc.Parameters.Add(new SqlParameter("@date", dates));
                makeupproc.Parameters.Add(new SqlParameter("@courseID", id));
                    conn.Open();
                    makeupproc.ExecuteNonQuery();
                    conn.Close();
                Response.Write("Exam Added Successfully");

            }
            catch (Exception ex)
                {
                   Response.Write("Error" + ex.Message);
                return;
                }
               
        }
    }
}
        