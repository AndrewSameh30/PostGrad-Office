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
    public partial class Linkpublication : System.Web.UI.Page
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


            SqlCommand command = new SqlCommand("linkPubThesis", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();

            SqlParameter thesisSerialNoParam = new SqlParameter("@thesisSerialNo", SqlDbType.Int);
            thesisSerialNoParam.Value =Convert.ToInt32(ThesisSerialNoTextBox.Text);
            command.Parameters.Add(thesisSerialNoParam);

            SqlParameter PubIDParam = new SqlParameter("@PubID", SqlDbType.Int);
            PubIDParam.Value = Convert.ToInt32(publicationNoTextBox.Text);
            command.Parameters.Add(PubIDParam);

            
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