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
    public partial class spage11 : System.Web.UI.Page
    {
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand listadvisors = new SqlCommand("Procedures_AdminListAdvisors", conn);
            listadvisors.CommandType = CommandType.StoredProcedure;
            conn.Open();


            using (SqlDataAdapter adapter = new SqlDataAdapter(listadvisors))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                conn.Close();


            }


        }


    }
}