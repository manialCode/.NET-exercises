using System;

namespace TP_5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void loadGrid()
        {
            ConexionBD conexionBD = new ConexionBD();
            string query = "SELECT S.Id_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, " +
                           "P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion " +
                           "FROM Sucursal S INNER JOIN Provincia P ON S.Id_ProvinciaSucursal = P.Id_Provincia";
            conexionBD.setGRD(grdSucursales, query);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) loadGrid();

        }

        protected void filtro_Click(object sender, EventArgs e)
        {
            if (TxtID == null) return;
            int ID = int.Parse(TxtID.Text);
            string query = $"SELECT S.Id_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, " +
                                  "P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion " +
                                  "FROM Sucursal S INNER JOIN Provincia P ON S. Id_ProvinciaSucursal = P.Id_Provincia " +
                                  $"WHERE S.Id_Sucursal = {ID}";
            ConexionBD conexionBD = new ConexionBD();
            conexionBD.setGRD(grdSucursales, query);
        }

        protected void Mostrar_Click(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}