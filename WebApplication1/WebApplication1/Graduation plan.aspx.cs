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
    public partial class Graduation_plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [FN_StudentViewGP](@student_ID)", conn);
            // cmd.CommandType=CommandType.StoredProcedure;

            string g = gradp.Text;
            if (g == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try
                {
                    cmd.Parameters.AddWithValue("@student_ID", g);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    conn.Close();
                }
                catch { 
                
                    Response.Write("Student ID Must be an Integer");
                }

            }

        }


        }
    }

    