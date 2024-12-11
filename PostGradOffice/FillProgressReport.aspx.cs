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
    public partial class FillProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentID"] == null || string.IsNullOrEmpty(Session["StudentID"].ToString()))
                Response.Redirect("Login.aspx");
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("FillProgressReport", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter SerialNoParam = new SqlParameter("@ThesisSerialNo", SqlDbType.Int);
            SerialNoParam.Value = Convert.ToInt32(ThesisSerialNoTextBox.Text);
            command.Parameters.Add(SerialNoParam);

            SqlParameter stateParam = new SqlParameter("@state", SqlDbType.Int);
            stateParam.Value = Convert.ToInt32(StateTextBox.Text);
            command.Parameters.Add(stateParam);

            SqlParameter descriptionParam = new SqlParameter("@description", SqlDbType.VarChar);
            descriptionParam.Value = descriptionTextBox.Text;
            command.Parameters.Add(descriptionParam);

            SqlParameter progressReportNoParam = new SqlParameter("@progressReportNo", SqlDbType.Int);
            progressReportNoParam.Value = Convert.ToInt32(progressReportNoTextBox.Text);
            command.Parameters.Add(progressReportNoParam);

            SqlParameter studentIDParam = new SqlParameter("@studentID", SqlDbType.Int);
            studentIDParam.Value = Convert.ToInt32(Session["StudentID"].ToString());
            command.Parameters.Add(studentIDParam);

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