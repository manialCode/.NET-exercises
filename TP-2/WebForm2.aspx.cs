﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lbtnRojo_Click(object sender, EventArgs e)
        {
            lblTextoColoreado.ForeColor = System.Drawing.Color.Red;
        }

        protected void lbtnAzul_Click(object sender, EventArgs e)
        {
            lblTextoColoreado.ForeColor = System.Drawing.Color.Blue;
        }

        protected void lbtnVerde_Click(object sender, EventArgs e)
        {
            lblTextoColoreado.ForeColor = System.Drawing.Color.Green;
        }
    }
}