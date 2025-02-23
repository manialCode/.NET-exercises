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
        /// <summary>
        /// Método que se ejecuta cuando la página se carga.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
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

        /// <summary>
        /// Carga las sucursales de una provincia específica.
        /// </summary>
        /// <param name="provincia">El nombre de la provincia.</param>
        private void CargarSucursales(string provincia)
        {
            lvSucursales.DataSource = _sucursalService.ObtenerSucursalesPorProvincia(provincia);
            lvSucursales.DataBind();
        }

        /// <summary>
        /// Maneja el evento de comando del botón de selección.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los argumentos del evento de comando.</param>
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

        /// <summary>
        /// Obtiene la tabla de selección de sucursales de la sesión.
        /// </summary>
        /// <returns>Una tabla de datos con las sucursales seleccionadas.</returns>
        private DataTable ObtenerTablaSeleccion()
        {
            if (Session["User_Selection"] == null)
                Session["User_Selection"] = CrearTablaSucursales();

            return (DataTable)Session["User_Selection"];
        }

        /// <summary>
        /// Crea una nueva tabla de sucursales.
        /// </summary>
        /// <returns>Una nueva tabla de datos con las columnas ID, Nombre y Descripcion.</returns>
        private DataTable CrearTablaSucursales()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            return dt;
        }

        /// <summary>
        /// Agrega una sucursal a la tabla de selección.
        /// </summary>
        /// <param name="table">La tabla de datos.</param>
        /// <param name="id">El ID de la sucursal.</param>
        /// <param name="nombre">El nombre de la sucursal.</param>
        /// <param name="descripcion">La descripción de la sucursal.</param>
        private void AgregarSucursal(DataTable table, string id, string nombre, string descripcion)
        {
            DataRow row = table.NewRow();
            row["ID"] = id;
            row["Nombre"] = nombre;
            row["Descripcion"] = descripcion;
            table.Rows.Add(row);
        }

        /// <summary>
        /// Verifica si una sucursal ya existe en la tabla de selección.
        /// </summary>
        /// <param name="table">La tabla de datos.</param>
        /// <param name="id">El ID de la sucursal.</param>
        /// <returns>True si la sucursal ya existe, de lo contrario false.</returns>
        private bool ExisteSucursal(DataTable table, string id)
        {
            return table.AsEnumerable().Any(row => row.Field<string>("ID") == id);
        }

        /// <summary>
        /// Maneja el evento de comando del botón de provincia.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los argumentos del evento de comando.</param>
        protected void BtnProvincia_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "SelectProvincie")
            {
                string provincia = e.CommandArgument.ToString();
                Session["ProvinciaSeleccionada"] = provincia;
                CargarSucursales(provincia);
            }
        }

        /// <summary>
        /// Maneja el evento de cambio de propiedades de la paginación.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los argumentos del evento de cambio de propiedades de la paginación.</param>
        protected void lvSucursales_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager pager = lvSucursales.FindControl("DataPager1") as DataPager;
            pager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            string provincia = Session["ProvinciaSeleccionada"] as string;
            CargarSucursales(provincia);
        }

        /// <summary>
        /// Maneja el evento de clic del botón de búsqueda.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreSucursal.Text.Trim();
            lvSucursales.DataSource = _sucursalService.BuscarSucursales(nombre);
            lvSucursales.DataBind();
        }
    }
}