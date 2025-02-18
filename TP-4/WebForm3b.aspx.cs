using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_4
{
    public partial class WebForm3b : System.Web.UI.Page
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-5CKDGIR\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Encrypt=True");
        /// <summary>
        /// Obtiene o establece la conexión SQL.
        /// </summary>
        public SqlConnection Con { get => con; set => con = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string TemaSeleccionado = Request.QueryString["TemaId"];

            if (!IsPostBack) {
                Con.Open();
                SqlCommand cmd = new SqlCommand($"select * from temas where {TemaSeleccionado} = IdTema", sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                grdLibros.DataSource = reader;
                grdLibros.DataBind();
                Con.Close();

            }
        }
    }
}