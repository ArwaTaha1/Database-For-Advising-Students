using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class certain_instrusctor_and_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [FN_StudentViewSlot](@CourseID, @InstructorID)", conn);
            // cmd.CommandType=CommandType.StoredProcedure;

            string id = iid.Text;
            string cID = cid.Text;
            if (id == "" || cID == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try
                {
                    cmd.Parameters.AddWithValue("@CourseID", cID);
                    cmd.Parameters.AddWithValue("@InstructorID", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Response.Write("success");
                    conn.Close();
                }
                catch
                {

                    Response.Write("Instructor ID and Course ID Must be Integers");
                }

            }
        }
    }
}