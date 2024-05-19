using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arwa
{
    public partial class missing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand missing = new SqlCommand("Procedures_ViewMS", conn);
            missing.CommandType = CommandType.StoredProcedure;
            string id = ID.Text;
            if (id == "" )
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try {
                missing.Parameters.Add(new SqlParameter("@StudentID", id));
                conn.Open();
                missing.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(missing);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridView1.DataSource = table;
                GridView1.DataBind();
                conn.Close();
                }
                catch {
                    Response.Write("Student ID must be an integer");
                }
            }
        }
    }
}