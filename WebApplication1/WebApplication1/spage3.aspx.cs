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
    public partial class spage3 : System.Web.UI.Page
    {
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand pending = new SqlCommand("select * from all_Pending_Requests", conn);
            pending.CommandType = CommandType.Text;
            conn.Open();


            using (SqlDataReader reader = pending.ExecuteReader())
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                conn.Close();


            }


        }


    }
}



