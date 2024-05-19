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
    public partial class DeletedSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void dslot(object sender, EventArgs e)
        {
            try
            {
              string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            String sem= TextBox1.Text;

            SqlCommand slotproc = new SqlCommand("Procedures_AdminDeleteSlots", conn);
            slotproc.CommandType = CommandType.StoredProcedure;
            slotproc.Parameters.Add(new SqlParameter("@current_semester", sem));

           
            
                conn.Open();
                slotproc.ExecuteNonQuery();
                Response.Write("Slot deleted");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.Message);
            }
           
            
            
        }
    }
}