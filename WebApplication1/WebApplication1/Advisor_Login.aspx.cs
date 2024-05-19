using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int id = Int16.Parse(username.Text);
                string pass = password.Text;
                SqlCommand login = new SqlCommand("FN_AdvisorLogin", conn);
                login.CommandType = CommandType.StoredProcedure;
                login.Parameters.Add(new SqlParameter("@advisor_Id", id));
                login.Parameters.Add(new SqlParameter("@password", pass));
                SqlParameter returnValueParam = login.Parameters.Add("@return_value", SqlDbType.Bit);
                returnValueParam.Direction = ParameterDirection.ReturnValue;
                bool success = false;
                conn.Open();
                login.ExecuteNonQuery();
                success = (bool)returnValueParam.Value;
                conn.Close();
                if (success == true)
                {
                    Session["AdvisorID"] = id;
                    Response.Write("Login Successful!");
                    Response.Redirect("Advisor.aspx");
                }
                else
                {
                    Response.Write("Login Failed!");
                }
            }
            catch(Exception ex)
            {
                Response.Write("Error: "+ex.Message);
            }


        }
    }
}