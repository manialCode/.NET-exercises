using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace TP_5
{
    /// <summary>
    /// Clase que maneja la conexión a la base de datos y proporciona métodos para ejecutar consultas y transacciones.
    /// </summary>
    public class ConexionBD
    {
        private string ruta = "Data Source=DESKTOP-5CKDGIR\\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        /// <summary>
        /// Ejecuta una consulta SQL que no devuelve resultados y devuelve el número de filas afectadas.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <returns>El número de filas afectadas.</returns>
        public int RunTransacction(string query)
        {
            int rows = 0;

            using (SqlConnection con = new SqlConnection(ruta))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return rows;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y enlaza los resultados a un control GridView.
        /// </summary>
        /// <param name="grd">El control GridView a enlazar.</param>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        public void setGRD(GridView grd, string query)
        {
            using (SqlConnection con = new SqlConnection(ruta))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        grd.DataSource = sqlDataReader;
                        grd.DataBind();
                    }
                }
            }
        }

        /// <summary>
        /// Ejecuta una consulta SQL y llena un control DropDownList con los resultados.
        /// </summary>
        /// <param name="ddl">El control DropDownList a llenar.</param>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        public void setDDL(DropDownList ddl, string query)
        {
            using (SqlConnection con = new SqlConnection(ruta))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ddl.Items.Add(sqlDataReader["DescripcionProvincia"] + "-" + sqlDataReader["Id_Provincia"]);
                        }
                    }
                }
            }
        }
    }
}