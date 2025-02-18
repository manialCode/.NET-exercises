using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        public class USER
        {
            public string Nombre { get; set; }
            public string PSW { get; set; }

            public USER(string nombre, string psw)
            {
                Nombre = nombre;
                PSW = psw;
            }
        }


        private bool isValid(TextBox item) {
            bool check = item == null;
            if(check) lblError.Text = "Todos los campos son requeridos";
            return !check; 
        }
        protected void submit(object sender, EventArgs e)
        {
            USER user = new USER("Juan", "1234");
            if (!isValid(txbName)) return;
            if (txbName.Text == user.Nombre && txbPassword.Text == user.PSW)
            {
                Response.Redirect("WebForm3a.aspx");
            }
            else lblError.Text="Usuario o Contraseña incorrecto";
            lblError.Text = string.Empty;
        }


    }
}