using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using TP_7.ConxionDB;

namespace TP_7_copy
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {
        private readonly SucursalService _sucursalService = new SucursalService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string provincia = Session["ProvinciaSeleccionada"] as string;
                if (!string.IsNullOrEmpty(provincia))
                {
                    CargarSucursales(provincia);
                }
            }
        }

        private void CargarSucursales(string provincia)
        {
            lvSucursales.DataSource = _sucursalService.ObtenerSucursalesPorProvincia(provincia);
            lvSucursales.DataBind();
        }

        protected void BtnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            string[] valores = e.CommandArgument.ToString().Split('|');

            if (valores.Length == 3)
            {
                string id = valores[0];
                string nombre = valores[1];
                string descripcion = valores[2];

                DataTable table = ObtenerTablaSeleccion();
                if (!ExisteSucursal(table, id))
                {
                    AgregarSucursal(table, id, nombre, descripcion);
                    Session["User_Selection"] = table;
                }
            }
        }

        private DataTable ObtenerTablaSeleccion()
        {
            if (Session["User_Selection"] == null)
                Session["User_Selection"] = CrearTablaSucursales();

            return (DataTable)Session["User_Selection"];
        }

        private DataTable CrearTablaSucursales()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            return dt;
        }

        private void AgregarSucursal(DataTable table, string id, string nombre, string descripcion)
        {
            DataRow row = table.NewRow();
            row["ID"] = id;
            row["Nombre"] = nombre;
            row["Descripcion"] = descripcion;
            table.Rows.Add(row);
        }

        private bool ExisteSucursal(DataTable table, string id)
        {
            return table.AsEnumerable().Any(row => row.Field<string>("ID") == id);
        }

        protected void BtnProvincia_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "SelectProvincie")
            {
                string provincia = e.CommandArgument.ToString();
                Session["ProvinciaSeleccionada"] = provincia;
                CargarSucursales(provincia);
            }
        }

        protected void lvSucursales_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager pager = lvSucursales.FindControl("DataPager1") as DataPager;
            pager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            string provincia = Session["ProvinciaSeleccionada"] as string;
            CargarSucursales(provincia);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreSucursal.Text.Trim();
            lvSucursales.DataSource = _sucursalService.BuscarSucursales(nombre);
            lvSucursales.DataBind();
        }
    }
}