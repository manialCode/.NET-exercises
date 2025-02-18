using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public bool checkInputs()
        {
            if (string.IsNullOrEmpty(cant1.Text) || string.IsNullOrEmpty(cant2.Text) ||
                string.IsNullOrEmpty(tbxP.Text) || string.IsNullOrEmpty(tbx2.Text))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                return false;
            }

            if (!Regex.IsMatch(cant1.Text, @"^\d+$") || !Regex.IsMatch(cant2.Text, @"^\d+$"))
            {
                lblError.Text = "Las cantidades deben ser números.";
                return false;
            }


            return true;
        }

        public string setTable() {
            int cant1List = int.Parse(cant1.Text);
            int cant2List = int.Parse(cant1.Text);
            string p1 = tbxP.Text;
            string p2 = tbx2.Text;
            string table = "<table> " +
                "<tr><td>Producto</td><td>Cantidad</td></tr>";
            table += "<tr>" +
                "<td>" +
                p1 + "</td>" +
                "<td>" +
                cant1List +
                "</td>" +
                "</tr>"; ;
            table += "<tr>" +
                "<td>" +
                p2 + "</td>" +
                "<td>" +
                cant2List +
                "</td>" +
                "</tr>";
            table += "<tr>" +
                "<td>Total</td>" +
                "<td>" +
                (cant1List + cant2List)+
                "</td>" +
                "</tr>" +
                "</table>";
            return table;
        }
        protected void button(object sender, EventArgs e)
        {

            if (!checkInputs()) return;
            string table = setTable();
            lblError.Text = string.Empty;
            tbx2.Text = "";
            tbxP.Text = "";
            cant1.Text = "";
            cant2.Text = "";
            lblInjection.Text = table;
        }
    }
}