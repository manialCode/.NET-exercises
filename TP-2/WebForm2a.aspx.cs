using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm2a : System.Web.UI.Page
    {
        private const string Path = "WebForm2b.aspx";

        private bool checkInputs()
        {
            lblError.Text = string.Empty;
            bool isValid = true;

            if (string.IsNullOrEmpty(txbName.Text))
            {
                lblError.Text += "El campo Nombre es obligatorio.<br/>";
                isValid = false;
            }

            if (string.IsNullOrEmpty(txbLastName.Text))
            {
                lblError.Text += "El campo Apellido es obligatorio.<br/>";
                isValid = false;
            }

            if (ddlCity.SelectedValue == null)
            {
                lblError.Text += "Debe seleccionar una ciudad.<br/>";
                isValid = false;
            }

            if (cblSubjects.SelectedIndex > 0)
            {
                lblError.Text += "Debe seleccionar al menos un tema.<br/>";
                isValid = false;
            }

            return isValid;
        }
        private void SetCityItems(DropDownList ddl)
        {
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem("Selecciona una zona", null));
            ddl.Items.Add(new ListItem("Gral. Pacheco", "zona norte"));
            ddl.Items.Add(new ListItem("San Miguel", "zona oeste"));
            ddl.Items.Add(new ListItem("Boedo", "zona sur"));
        }
        private void SetSubjectsItems(CheckBoxList cbl)
        {
            cbl.Items.Clear();
            cbl.Items.Add(new ListItem("Ciencias"));
            cbl.Items.Add(new ListItem("Literatura"));
            cbl.Items.Add(new ListItem("Historia"));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SetSubjectsItems(cblSubjects);
            SetCityItems(ddlCity);
        }

        protected void HandleClick(object sender, EventArgs e)
        {
           if(!checkInputs())return;
           lblError.Text = string.Empty;
            string selectedItems = "";
            foreach (ListItem item in cblSubjects.Items)
            {
                if (item.Selected)
                    selectedItems += item.Text;
            }
            base.Session["SelectedItems"] = selectedItems;
            Server.Transfer(Path);
        }
    }
}