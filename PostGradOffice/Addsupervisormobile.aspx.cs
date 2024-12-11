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
    public partial class Addsupervisormobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SupervisiorID"] == null || string.IsNullOrEmpty(Session["SupervisiorID"].ToString()))
                Response.Redirect("Login.aspx");
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("addMobile", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter IdParam = new SqlParameter("@ID", SqlDbType.Int);
            IdParam.Value = Convert.ToInt32(Session["SupervisiorID"].ToString());
            command.Parameters.Add(IdParam);

            SqlParameter MobileParam = new SqlParameter("@mobile_number", SqlDbType.VarChar);
            MobileParam.Value = Convert.ToInt32(MobileTextBox.Text);
            command.Parameters.Add(MobileParam);

            con.Open();
            int NoOfRows = command.ExecuteNonQuery();
            con.Close();

            if (NoOfRows > 0)
                ResultLabel.Text = "Data Saved successfully";
            else
                ResultLabel.Text = "error";
        }
    }
}