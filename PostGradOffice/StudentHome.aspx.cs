﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBproject
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentID"] == null || string.IsNullOrEmpty(Session["StudentID"].ToString()))
                Response.Redirect("Login.aspx");
        }
    }
}