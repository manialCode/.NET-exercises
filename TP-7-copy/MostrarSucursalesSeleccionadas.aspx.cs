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
        /// <summary>
        /// Método que se ejecuta cuando la página se carga.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica si la sesión "User_Selection" es nula y muestra un mensaje de advertencia si es así.
            if (Session["User_Selection"] == null)
                lbl_fallback.Text = "Por favor seleccione al menos un producto.";

            // Solo se ejecuta la primera vez que se carga la página y no en postbacks.
            if (!IsPostBack)
            {
                // Si la sesión "User_Selection" no es nula, enlaza los datos a la cuadrícula.
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