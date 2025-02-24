using System;
using System.Data;
using System.Data.SqlClient;

namespace TP_6.BD_Connection
{
    /// <summary>
    /// Manages database operations related to products.
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Connection string for the database.
        /// </summary>
        private String cnnString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False";

        /// <summary>
        /// Gets a open connection to the database.
        /// </summary>
        /// <returns>A <see cref="SqlConnection"/> object if the connection is successful; otherwise, null.</returns>
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(cnnString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a data adapter for the specified query.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <returns>A <see cref="SqlDataAdapter"/> object if the query is successful; otherwise, null.</returns>
        public SqlDataAdapter GetAdapter(string query)
        {
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter(query, GetConnection());
                return adapter;
            }
            catch (Exception ex) { return null; }
        }

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="comand">The <see cref="SqlCommand"/> object containing the command to execute.</param>
        /// <param name="SP_Name">The name of the stored procedure to execute.</param>
        /// <returns>The number of rows affected by the command.</returns>
        public int ExecuteProceed(SqlCommand comand, String SP_Name)
        {
            int AffectedRows = 0;

            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();

            cmd = comand;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP_Name;

            AffectedRows = cmd.ExecuteNonQuery();
            conn.Close();

            return AffectedRows;
        }
    }
}
