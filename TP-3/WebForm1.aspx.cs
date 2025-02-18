using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace TP_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private void CargarLocalidades()
        {
            var localidades = new List<ListItem>
            {
                new ListItem("Buenos Aires", "1000"),
                new ListItem("La Plata", "1900"),
                new ListItem("Mar del Plata", "7600"),
                new ListItem("Bahía Blanca", "8000"),
                new ListItem("Tandil", "7000")
            };

            ddlLocalidades.Items.AddRange(localidades.ToArray());
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarLocalidades();
        }

        protected void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }
        protected void GuardarLocalidad(object sender, EventArgs e)
        {
            if (localidad == null || txbPostal == null) return;
            bool isExist = false;
            foreach (ListItem item in ddlLocalidades.Items)
            {
                if (txbPostal.Text == item.Text) isExist = true;
            }

            bool isInt = int.TryParse(txbPostal.Text, out int postalCode);
            if (isInt && txbPostal.Text.Length == 4 && !isExist)
            { ddlLocalidades.Items.Add(new ListItem(localidad.Text, txbPostal.Text)); }

            string empty = string.Empty;
            localidad.Text = empty;
            txbPostal.Text = empty;
        }
    }
}
