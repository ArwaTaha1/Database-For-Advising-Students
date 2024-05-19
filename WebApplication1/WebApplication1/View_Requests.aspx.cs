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
    public partial class View_Requests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void View(object sender, EventArgs e)
        {
            try { 
            int advisor = Int16.Parse(aid.Text);
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
                SqlCommand View = new SqlCommand("SELECT * FROM FN_Advisors_Requests(@advisor_id)", conn);
                View.Parameters.Add(new SqlParameter("@advisor_id", advisor));
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(View);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                conn.Close();
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
    }
}