﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arwa
{
    public partial class Optional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void view(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand optional = new SqlCommand("Procedures_ViewOptionalCourse", conn);
            optional.CommandType = CommandType.StoredProcedure;
            string id = ID.Text;
            string s = semester.Text;
            if (id == "" || s == "")
            {
                Response.Write("Please insert in all fields");
                return;
            }
            else
            {
                try {
                optional.Parameters.Add(new SqlParameter("@StudentID", id));
                optional.Parameters.Add(new SqlParameter("@current_semester_code", s));
                conn.Open();
                optional.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(optional);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridView1.DataSource = table;
                GridView1.DataBind();
                conn.Close();
                }
                catch {
                    Response.Write("Student ID must be an integer");
                }
            }
        }
    }
}