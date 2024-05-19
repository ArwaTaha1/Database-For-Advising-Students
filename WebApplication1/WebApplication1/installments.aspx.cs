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
    public partial class installments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void numberofinstallments(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int id = Int16.Parse(TextBox1.Text);

                SqlCommand insproc = new SqlCommand("Procedures_AdminIssueInstallment", conn);
                insproc.CommandType = CommandType.StoredProcedure;
                insproc.Parameters.Add(new SqlParameter("@payment_id", id));
                conn.Open();
                insproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("successful");
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);

            }


          
        }
    }
}