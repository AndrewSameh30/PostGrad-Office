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
    public partial class Adddefense : System.Web.UI.Page
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


            SqlCommand command = new SqlCommand("AddDefenseGucian", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter SerialNoParam = new SqlParameter("@ThesisSerialNo", SqlDbType.Int);
            SerialNoParam.Value = Convert.ToInt32(ThesisSerialNoTextBox.Text);
            command.Parameters.Add(SerialNoParam);

            SqlParameter DefenseDateParam = new SqlParameter("@DefenseDate", SqlDbType.Date);
            DefenseDateParam.Value = Convert.ToDateTime(DefenseDateTextBox.Text).Date;
            command.Parameters.Add(DefenseDateParam);

            SqlParameter DefenseLocationParam = new SqlParameter("@DefenseLocation", SqlDbType.VarChar);
            DefenseLocationParam.Value = DefenseLocationTextBox.Text;
            command.Parameters.Add(DefenseLocationParam);

            con.Open();
            int NoOfRows=command.ExecuteNonQuery();
            con.Close();

            if (NoOfRows > 0)
                ResultLabel.Text = "Data Saved successfully";
            else
                ResultLabel.Text = "error";

        }
    }
}