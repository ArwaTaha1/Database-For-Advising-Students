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
    public partial class Advisor_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Button2.Visible = true;
            }
            
        }
        protected void insert(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
                string name = n.Text;
                string pass = p.Text;
                string email = em.Text;
                string office = o.Text;
                SqlCommand insert = new SqlCommand("Procedures_AdvisorRegistration", conn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.Add(new SqlParameter("@advisor_name", name));
                insert.Parameters.Add(new SqlParameter("@password", pass));
                insert.Parameters.Add(new SqlParameter("@email", email));
                insert.Parameters.Add(new SqlParameter("@office", office));
                SqlParameter outputParameter = new SqlParameter("@Advisor_id", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                insert.Parameters.Add(outputParameter);
                conn.Open();
                insert.ExecuteNonQuery();
                int advisorId = Convert.ToInt32(outputParameter.Value);
                Session["ID"] = advisorId;
                conn.Close();
                Response.Write($"Advisor Added Successfully! Advisor ID: {advisorId}");
                Page_Load(this, EventArgs.Empty);
            }
            catch (System.FormatException)
            {
                Response.Write("Invalid Inputs, Please ReInput");
                return;

            }
            catch (Exception ex)
            {
                Response.Write("An error occurred: " + ex.Message);
                return;
            }
        }
        protected void Advisor_Page(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Login.aspx");
        }

    }
}