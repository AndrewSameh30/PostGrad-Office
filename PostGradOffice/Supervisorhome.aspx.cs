using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBproject
{
    public partial class Supervisorhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SupervisiorID"] == null || string.IsNullOrEmpty(Session["SupervisiorID"].ToString()))
                Response.Redirect("Login.aspx");
        }
    }
}