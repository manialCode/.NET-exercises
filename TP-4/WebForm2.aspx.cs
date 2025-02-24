using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace TP_4
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False");

        /// <summary>
        /// Obtiene o establece la conexión SQL.
        /// </summary>
        public SqlConnection Con { get => con; set => con = value; }

        private void SetDdl(DropDownList ddl, string content, string value)
        {
            ddl.Items.Add(new ListItem(content, value));
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SetDdl(ddlEvalFiltroID, "Mayor a:", ">");
                SetDdl(ddlEvalFiltroID, "Menor a:", "<");
                SetDdl(ddlEvalFiltroID, "Igual a:", "=");

                SetDdl(ddlEvalFiltroCat, "Mayor a:", ">");
                SetDdl(ddlEvalFiltroCat, "Menor a:", "<");
                SetDdl(ddlEvalFiltroCat, "Igual a:", "=");
                Con.Open();
                SqlCommand cmd = new SqlCommand("select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos", Con);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                grvProductos.DataSource = sqlDataReader;
                grvProductos.DataBind();
                Con.Close();
            }
        }

        protected void Set_Filter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIdCat.Text) && string.IsNullOrEmpty(txbIdProducto.Text)) return;


            string cat = txbIdCat.Text;
            string id = txbIdProducto.Text;
            string evalCat = ddlEvalFiltroCat.SelectedValue ;
            string evalID = ddlEvalFiltroID.SelectedValue ;

            string query = "select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from productos where 1=1";

            if (!string.IsNullOrEmpty(id))
            {
                query += $" and IdProducto {evalID} @id";
            }

            if (!string.IsNullOrEmpty(cat))
            {
                query += $" and IdCategoría {evalCat} @cat";
            }

            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);

            if (!string.IsNullOrEmpty(id))
            {
                cmd.Parameters.AddWithValue("@id", id);
            }

            if (!string.IsNullOrEmpty(cat))
            {
                cmd.Parameters.AddWithValue("@cat", cat);
            }

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            grvProductos.DataSource = sqlDataReader;
            grvProductos.DataBind();
            Con.Close();
            txbIdCat.Text = string.Empty;
            txbIdProducto.Text = string.Empty;
        }

        protected void Clear_Filter(object sender, EventArgs e)
        {
            txbIdCat.Text = string.Empty;
            txbIdProducto.Text = string.Empty;
            Con.Open();
            SqlCommand cmd = new SqlCommand(
                "select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad " +
                "from Productos", Con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            grvProductos.DataSource = sqlDataReader;
            grvProductos.DataBind();
            Con.Close();
        }

    }
}
