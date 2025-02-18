using System;
using System.Data;
using System.Data.SqlClient;

namespace TP_6.BD_Connection
{
    /// <summary>
    /// Manages database operations related to products.
    /// </summary>
    public class ProductsManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsManager"/> class.
        /// </summary>
        public ProductsManager()
        {
        }

        /// <summary>
        /// Retrieves a DataTable based on the specified name and SQL query.
        /// </summary>
        /// <param name="Name">The name of the DataTable.</param>
        /// <param name="sql">The SQL query to execute.</param>
        /// <returns>A <see cref="DataTable"/> containing the results of the query.</returns>
        private DataTable GetTable(string Name, String sql)
        {
            DataSet ds = new DataSet();
            DataAccess data = new DataAccess();
            SqlDataAdapter sqlDataAdapter = data.GetAdapter(sql);

            if (sqlDataAdapter == null)
            {
                throw new InvalidOperationException("Failed to get SqlDataAdapter.");
            }

            sqlDataAdapter.Fill(ds, Name);
            return ds.Tables[Name];
        }

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        /// <returns>A <see cref="DataTable"/> containing all products.</returns>
        public DataTable GetAllProducts()
        {
            return GetTable("Productos", "Select * from Productos");
        }


        /// <summary>
        /// Sets the parameters for the product deletion command.
        /// </summary>
        /// <param name="cmd">The <see cref="SqlCommand"/> object.</param>
        /// <param name="product">The <see cref="Product"/> object.</param>
        private void SetProductDeleteParams(ref SqlCommand cmd, Product product)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = cmd.Parameters.Add("@IDPRODUCTO", SqlDbType.Int);
            sqlParameter.Value = product.ID1;
        }
        /// <summary>
        /// Sets the parameters for the product deletion command.
        /// </summary>
        /// <param name="cmd">The <see cref="SqlCommand"/> object.</param>
        /// <param name="product">The <see cref="Product"/> object.</param>


        /// <summary>
        /// Sets the parameters for the product command.
        /// </summary>
        /// <param name="cmd">The <see cref="SqlCommand"/> object.</param>
        /// <param name="product">The <see cref="Product"/> object.</param>
        private void SetProductParams(ref SqlCommand cmd, Product product)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = cmd.Parameters.Add("@IDPRODUCTO", SqlDbType.Int);
            sqlParameter.Value = product.ID1;
            sqlParameter = cmd.Parameters.Add("@NOMBREPRODUCTO", SqlDbType.NVarChar, 40);
            sqlParameter.Value = product.Name1;
            sqlParameter = cmd.Parameters.Add("@CANTIDADPORUNIDAD", SqlDbType.NVarChar, 20);
            sqlParameter.Value = product.StockXUnits1;
            sqlParameter = cmd.Parameters.Add("@PRECIOUNIDAD", SqlDbType.Money);
            sqlParameter.Value = product.UnitPrice1;
        }

        /// <summary>
        /// Updates a product in the database.
        /// </summary>
        /// <param name="product">The <see cref="Product"/> object to update.</param>
        /// <returns>True if the product was updated successfully; otherwise, false.</returns>
        public bool UpdateProduct(Product product)
        {
            SqlCommand command = new SqlCommand();
            SetProductParams(ref command, product);
            DataAccess dataAccess = new DataAccess();
            int rowsAffected = dataAccess.ExecuteProceed(command, "spActualizarProducto");
            return rowsAffected == 1;
        }

        /// <summary>
        /// Deletes a product from the database.
        /// </summary>
        /// <param name="product">The <see cref="Product"/> object to hide.</param>
        /// <returns>True if the product is hidden successfully; otherwise, false.</returns>
        public bool DeleteProduct(Product product)
        {
            SqlCommand command = new SqlCommand();
            SetProductDeleteParams(ref command, product);
            DataAccess dataAccess = new DataAccess();
            int rowsAffected = dataAccess.ExecuteProceed(command, "spEliminarProducto");
            return rowsAffected == 1;
        }

        public bool HideProduct(Product product)
        {
            SqlCommand command = new SqlCommand();
            SetProductDeleteParams(ref command, product);
            DataAccess dataAccess = new DataAccess();
            int rowsAffected = dataAccess.ExecuteProceed(command, "spOcultarProducto");
            return rowsAffected == 1;
        }
    }
}