using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage == null)
            {
                Response.Redirect("WebForm2a.aspx");
                return;
            }

            string nombre, apellido, zona, temas;


            nombre = Request["txbName"].ToString();
            apellido = Request["txbLastName"].ToString();
            zona = Request["ddlCity"].ToString();
            temas = Session["SelectedItems"]?.ToString() ?? "";

            lblName.Text = nombre;
            lblApellido.Text = apellido;
            lblZona.Text = zona;
            lblTemas.Text = temas;
        }
    }
}