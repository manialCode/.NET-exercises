using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private void SetMemoryItems(DropDownList ddl)
        {
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem("2 GB: 200$", "200"));
            ddl.Items.Add(new ListItem("4 GB: 375$", "375"));
            ddl.Items.Add(new ListItem("6 GB: 500$", "500"));
        }

        private void SetDisplayItems(CheckBoxList cbl)
        {
            cbl.Items.Clear();
            cbl.Items.Add(new ListItem("Monitor LCD: 2000.50$", "2000.50"));
            cbl.Items.Add(new ListItem("HD 500GB: 550.50$", "550.50"));
            cbl.Items.Add(new ListItem("Grabador DVD: 1200$", "1200"));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  // Se ejecuta solo la primera vez
            {
                SetMemoryItems(ddlMemory);
                SetDisplayItems(cblDisplays);
            }
        }

        protected void calculate(object sender, EventArgs e)
        {
            float memory = float.Parse(ddlMemory.SelectedValue, CultureInfo.InvariantCulture);
            float displays = 0;

            foreach (ListItem item in cblDisplays.Items)
            {
                if (item.Selected)
                {
                    displays += float.Parse(item.Value, CultureInfo.InvariantCulture);
                }
            }

            float precioFinal = displays + memory;
            lblPrecioFinal.Text = precioFinal.ToString("N2");  // Formato con dos decimales
        }
    }
}