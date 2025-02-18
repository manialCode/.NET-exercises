using System;

namespace TP_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void setDDL()
        {
            String consulta = "SELECT * FROM Provincia";
            ConexionBD con = new ConexionBD();
            con.setDDL(DdlProvincias, consulta);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) setDDL();
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();
            string nombre = txtNombreSuc.Text ?? "";

            string query = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('" + txtNombreSuc.Text + "' , '" + txtDescripcionSuc.Text + "' , '" + DdlProvincias.SelectedIndex + "' , '" + txtDireccionSuc.Text + "')"; 
            int ct = conexionBD.RunTransacction(query);
            if (ct == 0) return;

            txtNombreSuc.Text = "";
            txtDescripcionSuc.Text = "";
            txtDireccionSuc.Text = "";
        }
    }
}