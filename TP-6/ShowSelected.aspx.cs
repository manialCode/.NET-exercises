using System;
using System.Data;
using System.Web.UI.WebControls;

namespace TP_6
{
    public partial class ShowSelected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Selection"]
                == null)
            {
                lbl_fallback.Text= "Por favor seleccione al menos un proudcto.";
            }
            if (!IsPostBack)
            {
                if (Session["User_Selection"]
                != null)
                {
                    grd_Products.DataSource = (DataTable)Session["User_Selection"];
                    grd_Products.DataBind();
                }
            }
        }

        protected void grd_Products_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Font.Bold = true;
                e.Row.Cells[3].Font.Bold = true;
            }
        }
    }
}