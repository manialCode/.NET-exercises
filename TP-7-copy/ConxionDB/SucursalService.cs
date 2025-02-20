using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace TP_7.ConxionDB
{
    public class SucursalService
    {
        private readonly DataAccess _dataAccess;

        public SucursalService()
        {
            _dataAccess = new DataAccess();
        }

        /// <summary>
        /// Obtiene la lista de sucursales filtradas por provincia.
        /// </summary>
        public DataTable ObtenerSucursalesPorProvincia(string provincia)
        {
            if (string.IsNullOrEmpty(provincia))
                return new DataTable();

            string query = $@"
                SELECT s.[Id_Sucursal], s.[NombreSucursal], s.[DescripcionSucursal], s.[URL_Imagen_Sucursal]
                FROM [Sucursal] s
                INNER JOIN [Provincia] p ON s.Id_ProvinciaSucursal = p.Id_Provincia
                WHERE p.DescripcionProvincia = @provincia";

            SqlDataAdapter adapter = _dataAccess.GetAdapter(query, new SqlParameter("@provincia", provincia));
            return ObtenerDataTable(adapter);
        }

        /// <summary>
        /// Busca sucursales por nombre.
        /// </summary>
        public DataTable BuscarSucursales(string nombre)
        {
            string query = @"
                SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal]
                FROM [Sucursal]
                WHERE [NombreSucursal] LIKE @nombre";

            SqlDataAdapter adapter = _dataAccess.GetAdapter(query, new SqlParameter("@nombre", "%" + nombre + "%"));
            return ObtenerDataTable(adapter);
        }

        /// <summary>
        /// Convierte un SqlDataAdapter en un DataTable.
        /// </summary>
        private DataTable ObtenerDataTable(SqlDataAdapter adapter)
        {
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Sucursal");
            return ds.Tables["Sucursal"];
        }
    }
}