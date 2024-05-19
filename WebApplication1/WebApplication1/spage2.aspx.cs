using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_7
{
    public partial class spage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand liststudadvisors = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            liststudadvisors.CommandType = CommandType.StoredProcedure;
            conn.Open();


            using (SqlDataAdapter adapter = new SqlDataAdapter(liststudadvisors))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                conn.Close();


            }
            


            }
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }


    }
}