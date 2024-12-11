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
    public partial class addPublication : System.Web.UI.Page
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


            SqlCommand command = new SqlCommand("addPublication", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter TitleParam = new SqlParameter("@title", SqlDbType.VarChar);
            TitleParam.Value = TitleTextBox.Text;
            command.Parameters.Add(TitleParam);

            SqlParameter pubDateParam = new SqlParameter("@pubDate", SqlDbType.Date);
            pubDateParam.Value =Convert.ToDateTime(DateTextBox.Text);
            command.Parameters.Add(pubDateParam);

            SqlParameter hostParam = new SqlParameter("@host", SqlDbType.VarChar);
            hostParam.Value = HostTextBox.Text;
            command.Parameters.Add(hostParam);

            SqlParameter placeParam = new SqlParameter("@place", SqlDbType.VarChar);
            placeParam.Value = PlaceTextBox.Text;
            command.Parameters.Add(placeParam);

            SqlParameter acceptedParam = new SqlParameter("@accepted", SqlDbType.Bit);
            acceptedParam.Value = AcceptedCheckBox.Checked;
            command.Parameters.Add(acceptedParam);

            con.Open();
            int NoOfRows = command.ExecuteNonQuery();
            con.Close();

            if (NoOfRows > 0)
                ResultLabel.Text = "Data saved successfully";
            else
                ResultLabel.Text = "error";
        }
    }
}