using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace TP_7.ConxionDB
{
    /// <summary>
    /// Handles database operations.
    /// </summary>
    public class DataAccess
    {
        private readonly string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False";

        /// <summary>
        /// Creates and opens a database connection.
        /// </summary>
        /// <returns>An open <see cref="SqlConnection"/> instance.</returns>
        private SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Gets a data adapter for a query.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>A <see cref="SqlDataAdapter"/> object.</returns>
        public SqlDataAdapter GetAdapter(string query, params SqlParameter[] parameters)
        {
            try
            {
                var connection = CreateConnection();
                var command = new SqlCommand(query, connection);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return new SqlDataAdapter(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Executes a stored procedure and returns the number of affected rows.
        /// </summary>
        /// <param name="storedProcName">The name of the stored procedure.</param>
        /// <param name="parameters">Parameters for the stored procedure.</param>
        /// <returns>The number of affected rows, or -1 in case of error.</returns>
        public int ExecuteStoredProcedure(string storedProcName, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                using (var command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing stored procedure: {ex.Message}");
                return -1; // Indica error
            }
        }

        /// <summary>
        /// Executes a query and returns the result as a DataTable.
        /// </summary>
        /// <param name="query">The SQL query.</param>
        /// <param name="parameters">Optional parameters.</param>
        /// <returns>A <see cref="DataTable"/> with the results.</returns>
        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        return resultTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                return null;
            }
        }
    }
}
