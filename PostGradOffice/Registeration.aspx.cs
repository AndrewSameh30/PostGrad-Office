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
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserTypeRadioButtonList.SelectedValue == "0")
                {
                    GUCianRow.Visible = true;
                    addressRow.Visible = true;
                    isNationalRow.Visible = false;
                }
                else if (UserTypeRadioButtonList.SelectedValue == "1")
                {
                    GUCianRow.Visible = false;
                    addressRow.Visible = false;
                    isNationalRow.Visible = false;
                }
                else
                {
                    GUCianRow.Visible = false;
                    addressRow.Visible = false;
                    isNationalRow.Visible = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();

            command.Parameters.Clear();

            SqlParameter FirstNameParam = new SqlParameter("@first_name", SqlDbType.VarChar);
            FirstNameParam.Value = FNameTextBox.Text;
            command.Parameters.Add(FirstNameParam);

            SqlParameter LastNameParam = new SqlParameter("@last_name", SqlDbType.VarChar);
            LastNameParam.Value = LNameTextBox.Text;
            command.Parameters.Add(LastNameParam);

            SqlParameter PasswordParam = new SqlParameter("@password", SqlDbType.VarChar);
            PasswordParam.Value = PasswordTextBox.Text;
            command.Parameters.Add(PasswordParam);

            SqlParameter FacultyParam = new SqlParameter("@faculty", SqlDbType.VarChar);
            FacultyParam.Value = facultyTextBox.Text;
            command.Parameters.Add(FacultyParam);

            SqlParameter EmailParam = new SqlParameter("@email", SqlDbType.VarChar);
            EmailParam.Value = emailTextBox.Text;
            command.Parameters.Add(EmailParam);

            if (UserTypeRadioButtonList.SelectedValue == "0")
            {
                SqlParameter GucianParam = new SqlParameter("@Gucian", SqlDbType.Bit);
                GucianParam.Value = Convert.ToInt32(GUCianCheckBox.Checked);
                command.Parameters.Add(GucianParam);

                command.Parameters.Add(new SqlParameter("@address", addressTextBox.Text));
                command.CommandText = "StudentRegister";
            }

            else if (UserTypeRadioButtonList.SelectedValue == "1")
            {
                command.CommandText = "SupervisorRegister";

            }

            else
            {
                SqlParameter isNationalParam = new SqlParameter("@isNational", SqlDbType.Bit);
                isNationalParam.Value = Convert.ToInt32(isNationalCheckBox.Checked);
                command.Parameters.Add(isNationalParam);

                command.CommandText = "ExaminerRegister";
            }
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            int NoOfRows = command.ExecuteNonQuery();
            con.Close();

            if (NoOfRows > 0)
                ResultLabel.Text = "Data Saved successfully";
            else
                ResultLabel.Text = "error";
        }

        protected void UserTypeRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTypeRadioButtonList.SelectedValue == "0")
            {
                GUCianRow.Visible = true;
                addressRow.Visible = true;
                isNationalRow.Visible = false;
            }
            else if (UserTypeRadioButtonList.SelectedValue == "1")
            {
                GUCianRow.Visible = false;
                addressRow.Visible = false;
                isNationalRow.Visible = false;
            }
            else
            {
                GUCianRow.Visible = false;
                addressRow.Visible = false;
                isNationalRow.Visible = true;
            }
        }
    }
}