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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBprojectConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("userLogin", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter IDParam = new SqlParameter("@id", SqlDbType.Int);
            IDParam.Value = Convert.ToInt32(IDTextBox.Text);
            command.Parameters.Add(IDParam);

            SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar);
            passwordParam.Value = passwordTextBox.Text;
            command.Parameters.Add(passwordParam);

            SqlParameter SuccessParam = new SqlParameter("@success", SqlDbType.Bit);
            SuccessParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(SuccessParam);

            SqlParameter TypeParam = new SqlParameter("@type", SqlDbType.Int);
            TypeParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(TypeParam);

            con.Open();
            command.ExecuteNonQuery();
            bool Success = Convert.ToBoolean(SuccessParam.Value);
            
            con.Close();

            if (Success)
            {
                int type = Convert.ToInt32(TypeParam.Value);
                if (type == 0)
                {
                    Session["StudentID"] = IDTextBox.Text;
                    Session["isGUCian"] = true;
                    Response.Redirect("Studenthome.aspx");
                }
                else if (type == 4)
                {
                    Session["StudentID"] = IDTextBox.Text;
                    Session["isGUCian"] = false;
                    Response.Redirect("Studenthome.aspx");
                }
                else if (type == 2)
                {
                    Session["SupervisiorID"] = IDTextBox.Text;
                    Response.Redirect("Supervisorhome.aspx");
                }
                else if (type == 1)
                {
                    ResultLabel.Text = "This id belongs to admin but it is not implemented because it is not mandatory";
                }
                else if (type == 3)
                {
                    ResultLabel.Text = "This id belongs to examiner but it is not implemented because it is not mandatory";
                }
                else
                {
                    ResultLabel.Text = "User type is undefined";
                }
                
            }
            else
                ResultLabel.Text = "Invalid User Name or Password";
        }
    }
}