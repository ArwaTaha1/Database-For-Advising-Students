﻿using System;
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
    public partial class Courses_and_slots_and_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("SELECT*FROM Courses_Slots_Instructor", conn);
            // cmd.CommandType=CommandType.StoredProcedure;

            string g = ido.Text;
            if (g == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try
                {
                    cmd.Parameters.AddWithValue("courseID", g);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    conn.Close();
                }
                catch
                {

                    Response.Write("Student ID Must be an Integer");
                }

            }
        }
    }
}
