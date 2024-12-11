using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBproject
{
    public partial class StudentProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentID"] == null || string.IsNullOrEmpty(Session["StudentID"].ToString()))
                Response.Redirect("Login.aspx");

                string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand command = new SqlCommand("viewMyProfile", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Clear();

                SqlParameter IdParam = new SqlParameter("@studentId", SqlDbType.Int);
                IdParam.Value = Convert.ToInt32(Session["StudentID"].ToString());
                command.Parameters.Add(IdParam);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FirstNameTextBox.Text = reader["firstName"].ToString();
                    LastNameTextBox.Text = reader["lastName"].ToString();
                    TypeTextBox.Text = reader["type"].ToString();
                    AddressTextBox.Text = reader["address"].ToString();
                    EmailTextBox.Text = reader["email"].ToString();

                }
                con.Close();
            
        }
        
    }
}