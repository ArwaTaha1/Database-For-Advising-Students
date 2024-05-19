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
    public partial class View_Advising_Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
                    string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                    SqlConnection conn = new SqlConnection(connStr);

                    SqlCommand liststudadvisors = new SqlCommand("AdminListStudentsWithAdvisors", conn);
                    liststudadvisors.CommandType = CommandType.StoredProcedure;
                    conn.Open();


                    SqlDataAdapter adapter = new SqlDataAdapter(liststudadvisors);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    int advisorID = Convert.ToInt32(Session["AdvisorID"]);
                    DataRow[] filteredRows = dataTable.Select($"advisor_id = {advisorID}");
                    DataTable newtable = dataTable.Clone();
                    foreach (DataRow row in filteredRows)
                    {
                        newtable.ImportRow(row);
                    }

                    if (newtable.Rows.Count > 0)
                    {
                        GridView1.DataSource = newtable;
                        GridView1.DataBind();
                    }
                    else
                    {
                        GridView1.Visible = false;
                        Response.Write("You don't have any advising students");
                    }

                    conn.Close();
                }
            catch (System.FormatException)
            {
                Response.Write("Invalid Inputs, Please ReInput");
                return;
            }
            catch(Exception ex)
            {
                Response.Write("Error: " + ex.Message);
                return;
            }
        }
        }
    }
