using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_6.BD_Connection;

namespace TP_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public void SetGrid()
        {
            ProductsManager productsManager = new ProductsManager();
            grd_Products.DataSource = productsManager.GetAllProducts();
            grd_Products.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                SetGrid();
                grd_Products.PagerStyle.HorizontalAlign = HorizontalAlign.Center;

            }
        }

        protected void grd_Products_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grd_Products.PageIndex = e.NewPageIndex;
            SetGrid(); 
        }

        protected void Deleting(object sender, GridViewDeleteEventArgs e)
        {
            Product product = new Product();
            ProductsManager productsManager = new ProductsManager();

            Label lblID = (Label)grd_Products.Rows[e.RowIndex].FindControl("lblID");
            Label lblNombre = (Label)grd_Products.Rows[e.RowIndex].FindControl("lblNombre");
            Label lblCantidad = (Label)grd_Products.Rows[e.RowIndex].FindControl("lblCantidad");
            Label lblPrecio = (Label)grd_Products.Rows[e.RowIndex].FindControl("lblPrecio");

            product.ID1 = int.Parse(lblID.Text);
            product.Name1 = lblNombre.Text;
            product.StockXUnits1 = lblCantidad.Text;
            product.UnitPrice1 = decimal.Parse(lblPrecio.Text);

            productsManager.DeleteProduct(product);
            SetGrid();
        }

        protected void Editing(object sender, GridViewEditEventArgs e)
        {
            grd_Products.PageIndex = e.NewEditIndex;
            SetGrid();
        }

        protected void Cancel(object sender, GridViewCancelEditEventArgs e)
        {
            grd_Products.EditIndex = -1; SetGrid();
        }

        protected void Updating(object sender, GridViewUpdateEventArgs e)
        {
            Product product = new Product();
            ProductsManager productsManager = new ProductsManager();

            Label lblID = (Label)grd_Products.Rows[e.RowIndex].FindControl("lbl_eit_ID");
            TextBox lblNombre = (TextBox)grd_Products.Rows[e.RowIndex].FindControl("txt_eit_Nombre");
            TextBox lblCantidad = (TextBox)grd_Products.Rows[e.RowIndex].FindControl("txt_eit_Cantidad");
            TextBox lblPrecio = (TextBox)grd_Products.Rows[e.RowIndex].FindControl("txt_eit_Precio");

            product.ID1 = int.Parse(lblID.Text);
            product.Name1 = lblNombre.Text;
            product.StockXUnits1 = lblCantidad.Text;
            product.UnitPrice1 = decimal.Parse(lblPrecio.Text);

            productsManager.UpdateProduct(product);

            grd_Products.EditIndex = -1;
            SetGrid();
        }
    }
}