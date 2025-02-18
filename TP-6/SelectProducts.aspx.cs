    using System;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    using TP_6.BD_Connection;

    namespace TP_6
    {
        public partial class SelectProducts : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProductGrid();
                UpdateProductCount();
            }
        }

        /// <summary>
        /// Agrega un producto a la tabla de selección del usuario.
        /// </summary>
        private void AddProductToTable(DataTable table, string id, string name, string supplier, string price)
        {
            DataRow row = table.NewRow();
            row["ID"] = id;
            row["Nombre"] = name;
            row["Proveedor"] = supplier;
            row["Precio"] = price;
            table.Rows.Add(row);
        }

        /// <summary>
        /// Maneja la paginación del GridView.
        /// </summary>
        protected void grd_Products_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grd_Products.PageIndex = e.NewPageIndex;
            LoadProductGrid();
        }

        /// <summary>
        /// Maneja la selección de un producto y lo guarda en sesión si no está repetido.
        /// </summary>
        protected void grd_Products_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = grd_Products.Rows[e.NewSelectedIndex];

            string id = GetLabelText(row, "lblID");
            string nombre = GetLabelText(row, "lblNombre");
            string proveedor = GetLabelText(row, "lblProveedor");
            string precio = GetLabelText(row, "lblPrecio");

            lbl_Selected_Product.Text = nombre;

            DataTable userSelection = GetUserSelectionTable();

            if (!ProductExists(userSelection, id))
            {
                AddProductToTable(userSelection, id, nombre, proveedor, precio);
                Session["User_Selection"] = userSelection;
                UpdateProductCount();
            }
        }

        /// <summary>
        /// Obtiene el texto de un Label dentro de una fila del GridView.
        /// </summary>
        private string GetLabelText(GridViewRow row, string labelId)
        {
            Label lbl = row.FindControl(labelId) as Label;
            return lbl != null ? lbl.Text : string.Empty;
        }

        /// <summary>
        /// Obtiene la tabla de selección del usuario desde la sesión o la crea si no existe.
        /// </summary>
        private DataTable GetUserSelectionTable()
        {
            if (Session["User_Selection"] == null)
            {
                Session["User_Selection"] = CreateSelectionTable();
            }
            return (DataTable)Session["User_Selection"];
        }

        /// <summary>
        /// Crea una nueva tabla para almacenar la selección del usuario.
        /// </summary>
        private DataTable CreateSelectionTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Precio", typeof(string));
            dt.Columns.Add("Proveedor", typeof(string));
            return dt;
        }

        /// <summary>
        /// Carga los productos en la grilla desde la base de datos.
        /// </summary>
        private void LoadProductGrid()
        {
            ProductsManager productsManager = new ProductsManager();
            grd_Products.DataSource = productsManager.GetAllProductsWithSupplier();
            grd_Products.DataBind();
        }

        /// <summary>
        /// Verifica si un producto ya está en la tabla.
        /// </summary>
        private bool ProductExists(DataTable table, string productId)
        {
            return table.AsEnumerable().Any(row => row.Field<string>("ID") == productId);
        }

        /// <summary>
        /// Botón para eliminar todas las selecciones.
        /// </summary>
        protected void btn_clear_Click(object sender, EventArgs e)
        {
            Session["User_Selection"] = null;
            lbl_LastRow.Text = "Todas las selecciones borradas";
            UpdateProductCount();
        }

        /// <summary>
        /// Botón para eliminar la última selección.
        /// </summary>
        protected void btn_clear_last_Click(object sender, EventArgs e)
        {
            ShowLastRow();
            RemoveLastRow();
        }

        /// <summary>
        /// Elimina la última selección guardada en sesión.
        /// </summary>
        public void RemoveLastRow()
        {
            DataTable dt = GetUserSelectionTable();
            if (dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(dt.Rows.Count - 1);
                Session["User_Selection"] = dt;
                UpdateProductCount();
            }
        }

        /// <summary>
        /// Muestra la última fila seleccionada en un Label.
        /// </summary>
        public void ShowLastRow()
        {
            DataTable dt = GetUserSelectionTable();
            if (dt.Rows.Count > 0)
            {
                DataRow lastRow = dt.Rows[dt.Rows.Count - 1];
                lbl_LastRow.Text = $"ID: {lastRow["ID"]}, Nombre: {lastRow["Nombre"]}";
            }
        }

        /// <summary>
        /// Actualiza el label con la cantidad de productos seleccionados.
        /// </summary>
        private void UpdateProductCount()
        {
            DataTable dt = GetUserSelectionTable();

            if (dt.Rows.Count > 0)
            {
                lbl_ProductCount.Text = $"Productos seleccionados: {dt.Rows.Count}";
            }
            else
            {
                lbl_ProductCount.Text = "En espera de selecciones...";
            }
        }

    }
}