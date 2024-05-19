using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_7
{
    public partial class spage7 : System.Web.UI.Page
    {
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void page23(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand course = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
                course.CommandType = CommandType.StoredProcedure;

                int s = Int16.Parse(sid.Text);
                int a = Int16.Parse(aid.Text);


                if (sid.Text == "" || aid.Text == "")
                {

                    Response.Write("One of the inputs is null");
                    return;
                }
                else
                {




                    course.Parameters.Add(new SqlParameter("@studentID", s));
                    course.Parameters.Add(new SqlParameter("@advisorID", a));
                    conn.Open();
                    course.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("success");


                }
            }
            catch   (Exception ex) 
            {
                Response.Write("wrong data format or the advisor does not exist");
            }



            

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
