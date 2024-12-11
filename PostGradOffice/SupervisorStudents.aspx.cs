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
    public partial class SupervisorStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SupervisiorID"] == null || string.IsNullOrEmpty(Session["SupervisiorID"].ToString()))
                Response.Redirect("Login.aspx");

            string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            
            SqlCommand command = new SqlCommand("ViewSupStudentsYears", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter IdParam = new SqlParameter("@supervisorID", SqlDbType.Int);
            IdParam.Value = Convert.ToInt32(Session["SupervisiorID"].ToString());
            command.Parameters.Add(IdParam);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            con.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
    }
}