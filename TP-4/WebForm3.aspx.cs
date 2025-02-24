using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Encrypt=True");
        /// <summary>
        /// Obtiene o establece la conexión SQL.
        /// </summary>
        public SqlConnection Con { get => con; set => con = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select * from temas",Con);
                SqlDataReader reader = cmd.ExecuteReader();

                ddlTemas.DataSource = reader;
                ddlTemas.DataTextField = "Tema";
                ddlTemas.DataValueField = "idTema";
                ddlTemas.Items.Insert(0, new ListItem("Seleccione un tema", ""));
                Con.Close();
            }
        }

        protected void showBooks_Click(object sender, EventArgs e)
        {
            int TemaSeleccionado = int.Parse(ddlTemas.SelectedValue);
            Response.Redirect($"WebForm3b.aspx?TemaId={TemaSeleccionado}");

        }
    }
}
