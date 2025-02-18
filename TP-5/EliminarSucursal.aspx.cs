using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_5
{
    public partial class EliminarSucursalaspx : System.Web.UI.Page
    {
        private ConexionBD conexionBD = new ConexionBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDSucursal == null) return;
            int ID = int.Parse(txtIDSucursal.Text);
            string query = $"delete from sucursal where Id_Sucursal = {ID}";
            int result = conexionBD.RunTransacction(query);
            if (result == 0) { txtIDSucursal.Text = "realice de nuevo la accion con valores validos"; } 
            txtIDSucursal.Text = string.Empty;
        }
    }
}