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
    public partial class AddExaminer : System.Web.UI.Page
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


            SqlCommand command = new SqlCommand("AddExaminer", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter SerialNoParam = new SqlParameter("@ThesisSerialNo", SqlDbType.Int);
            SerialNoParam.Value = Convert.ToInt32(ThesisSerialNoTextBox.Text);
            command.Parameters.Add(SerialNoParam);

            SqlParameter DefenseDateParam = new SqlParameter("@DefenseDate", SqlDbType.Date);
            DefenseDateParam.Value = Convert.ToDateTime(DefenseDateTextBox.Text).Date;
            command.Parameters.Add(DefenseDateParam);

            SqlParameter NameParam = new SqlParameter("@ExaminerName", SqlDbType.VarChar);
            NameParam.Value = ExaminerNameTextBox.Text;
            command.Parameters.Add(NameParam);

            SqlParameter PasswordParam = new SqlParameter("@Password", SqlDbType.VarChar);
            PasswordParam.Value = PasswordTextBox.Text;
            command.Parameters.Add(PasswordParam);

            SqlParameter NationalParam = new SqlParameter("@National", SqlDbType.Bit);
            NationalParam.Value = Convert.ToInt32(NationalCheckBox.Checked);
            command.Parameters.Add(NationalParam);

            SqlParameter fieldOfWorkParam = new SqlParameter("@fieldOfWork", SqlDbType.VarChar);
            fieldOfWorkParam.Value = fieldOfWorkTextBox.Text;
            command.Parameters.Add(fieldOfWorkParam);

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