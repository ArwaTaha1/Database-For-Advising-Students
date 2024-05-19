using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class unpaid_installment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
           
           
                try
                {
                    SqlCommand cmd = new SqlCommand("FN_StudentUpcoming_installment", conn);
                    string id = sID.Text;
                    if (id == "")
                    {
                        Response.Write("Please insert in all fields");
                        return;
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_ID", id);
                    SqlParameter returnValueParam = cmd.Parameters.Add("@return_value", SqlDbType.DateTime);
                    returnValueParam.Direction = ParameterDirection.ReturnValue;
                    DateTime d ;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                if (returnValueParam.Value != DBNull.Value && returnValueParam.Value is DateTime)
                {
                    d = (DateTime)returnValueParam.Value;
                    Response.Write($"Deadline: {d}");
                }
                else
                {
                    Response.Write("No Upcoming Installments");
                }
                conn.Close();
                    
                }
                catch (Exception ex)
               {

                Response.Write("Student ID must be an integer");
                return;
            }

            }
        }
    
}
