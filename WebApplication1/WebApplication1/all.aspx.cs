using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Reflection.Emit;

namespace arwa
{
    public partial class all : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void view(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo. FN_SemsterAvailableCourses(@semstercode)", conn);
            // cmd.CommandType=CommandType.StoredProcedure;

            string s = semester.Text;
            if (s == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try {
                cmd.Parameters.AddWithValue("@semstercode", s);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                conn.Close();
                }
                catch {
                    Response.Write("Semester Code Invalid");
                }
               
            }
        }
    }
}