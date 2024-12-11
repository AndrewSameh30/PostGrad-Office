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
    public partial class EvaluateProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SupervisiorID"] == null || string.IsNullOrEmpty(Session["SupervisiorID"].ToString()))
                Response.Redirect("Login.aspx");
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(evaluationTextBox.Text))
            {
                ResultLabel.Text = "Enter evaluation value";
                return;
            }
            else if (Convert.ToInt32(evaluationTextBox.Text) >3 || Convert.ToInt32(evaluationTextBox.Text)<0)
            {
                ResultLabel.Text = "evaluation value should be 0 to 3";
                return;
            }
            string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("EvaluateProgressReport", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter IdParam = new SqlParameter("@supervisorID", SqlDbType.Int);
            IdParam.Value = Convert.ToInt32(Session["SupervisiorID"].ToString());
            command.Parameters.Add(IdParam);

            SqlParameter SerialNoParam = new SqlParameter("@ThesisSerialNo", SqlDbType.Int);
            SerialNoParam.Value = Convert.ToInt32(ThesisSerialNoTextBox.Text);
            command.Parameters.Add(SerialNoParam);

            SqlParameter progressReportNoDateParam = new SqlParameter("@progressReportNo", SqlDbType.Int);
            progressReportNoDateParam.Value = progressReportNoTextBox.Text;
            command.Parameters.Add(progressReportNoDateParam);

            SqlParameter evaluationParam = new SqlParameter("@evaluation", SqlDbType.VarChar);
            evaluationParam.Value = evaluationTextBox.Text;
            command.Parameters.Add(evaluationParam);

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