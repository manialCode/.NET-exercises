using System;
using System.Data;

namespace TP_6.BD_Connection
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VerificarSesion();
            }
        }

        /// <summary>
        /// Verifica si hay elementos en la sesión y actualiza el estado del botón.
        /// </summary>
        private void VerificarSesion()
        {
            if (Session["User_Selection"] == null || ((DataTable)Session["User_Selection"]).Rows.Count == 0)
            {
                btn_RestoreSelection.Enabled = false;
                btn_RestoreSelection.Attributes["onclick"] = "openModal(true); return false;";
            }
            else
            {
                btn_RestoreSelection.Enabled = true;
                btn_RestoreSelection.Attributes["onclick"] = "openModal(false); return false;";
            }
        }


        protected void btn_RestoreSelection_Click(object sender, EventArgs e)
        {

        }

        protected void btnConfirmRestore_Click(object sender, EventArgs e)
        {
            Session["User_Selection"] = null;
            VerificarSesion();

        }
    }
}