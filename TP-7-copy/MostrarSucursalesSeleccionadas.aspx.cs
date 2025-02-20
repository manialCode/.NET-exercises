using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP_7_copy
{
    public partial class MostrarSucursalesSeleccionadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Selection"] == null) lbl_fallback.Text = "Por favor seleccione al menos un proudcto.";
            if (!IsPostBack)
            {
                if (Session["User_Selection"] != null)
                {
                    DataTable table = (DataTable)Session["User_Selection"];
                    grdSelecciones.DataSource = table;
                    grdSelecciones.DataBind();
                } 

            }
        }
    }
}