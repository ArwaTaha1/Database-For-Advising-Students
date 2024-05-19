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
    public partial class transcript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MyTranscript(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("Select* From Students_Courses_transcript", conn);
            // cmd.CommandType=CommandType.StoredProcedure;

            string g = Button1.Text;
            if (g == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try
                {
                    cmd.Parameters.AddWithValue("id", g);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    conn.Close();
                }
                catch
                {

                    Response.Write("error");
                }

            }
        }
    }
}