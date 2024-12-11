using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBproject
{
    public partial class Signout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["StudentID"] = null;
            Session["SupervisiorID"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}