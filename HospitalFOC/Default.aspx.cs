﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalFOC
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userid = (string) Session["id_paciente"];
            if (!IsPostBack)
            {
                if (userid == "" || userid == null)       
                    Response.Redirect("/Login.aspx");
                   
            }

        }
    }
}