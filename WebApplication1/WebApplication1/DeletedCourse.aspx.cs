using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.ComponentModel;

namespace project
{
    public partial class DeletedCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void coursed(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int id=Int16.Parse(TextBox1.Text);
                

                    SqlCommand deletedproc = new SqlCommand("Procedures_AdminDeleteCourse", conn);
                    deletedproc.CommandType = CommandType.StoredProcedure;
                    deletedproc.Parameters.Add(new SqlParameter("@courseID", id));


                    try
                    {
                        conn.Open();
                        deletedproc.ExecuteNonQuery();
                   
                    Console.Write("Courses deleted");
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Error" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }


            }
            catch (Exception globalex)
            {
                Console.Write("Global Error:" + globalex.Message);
                Console.Write(globalex.ToString());
            }

            Response.Write("successful");



        }
        
       
    }
}
