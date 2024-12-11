using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBproject
{
    public partial class Student : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isGUCian"] != null && (!string.IsNullOrEmpty(Session["isGUCian"].ToString())))
            {
                if (Convert.ToBoolean(Session["isGUCian"].ToString()))
                    CourseLink.Visible = false;
                else
                    CourseLink.Visible = true;
            }
        }
    }
}