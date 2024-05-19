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
    public partial class required : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand required = new SqlCommand("Procedures_ViewRequiredCourses", conn);
            required.CommandType = CommandType.StoredProcedure;
            string id = ID.Text;
            string s = semester.Text;
            if (id == "" || s == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try{
                required.Parameters.Add(new SqlParameter("@StudentID", id));
                required.Parameters.Add(new SqlParameter("@current_semester_code", s));
                conn.Open();
                required.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(required);
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