using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace TP_4
{
    /// <summary>
    /// Clase parcial para la página WebForm1.
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False");

        /// <summary>
        /// Obtiene o establece la conexión SQL.
        /// </summary>
        public SqlConnection Con { get => con; set => con = value; }

        /// <summary>
        /// Carga datos en un DropDownList desde una consulta SQL.
        /// </summary>
        /// <param name="ddl">El DropDownList en el que se cargarán los datos.</param>
        /// <param name="query">La consulta SQL para obtener los datos.</param>
        /// <param name="textField">El campo de texto que se mostrará en el DropDownList.</param>
        /// <param name="valueField">El campo de valor que se usará en el DropDownList.</param>
        /// <param name="initialText">El texto inicial que se mostrará en el primer elemento del DropDownList.</param>
        private void LoadData(DropDownList ddl, string query, string textField, string valueField, string initialText)
        {
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            ddl.DataSource = reader;
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem(initialText, ""));
            reader.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga la página.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Con.Open();
                LoadData(
                    ddlProvinciaInicio, 
                    "select * from Provincias", 
                    "NombreProvincia", 
                    "IdProvincia", 
                    "Seleccione una provincia");
                Con.Close();
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia la selección en ddlProvinciaInicio.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            LoadData(
                ddlLocalidadInicio, 
                $"select IdLocalidad, NombreLocalidad from Localidades where IdProvincia = {ddlProvinciaInicio.SelectedValue}",
                "NombreLocalidad", 
                "IdLocalidad", 
                "Seleccione una localidad");
            Con.Close();
            Con.Open();
            LoadData(
                ddlProvinciaFin, 
                $"select * from Provincias where not idProvincia = {ddlProvinciaInicio.SelectedValue}",
                "NombreProvincia",
                "IdProvincia", 
                "Seleccione una provincia");
            Con.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia la selección en ddlProvinciaFin.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        protected void ddlProvinciaFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            LoadData(
                ddlLocalidadFin, 
                $"select IdLocalidad, NombreLocalidad from Localidades where IdProvincia = {ddlProvinciaFin.SelectedValue}", 
                "NombreLocalidad", 
                "IdLocalidad", 
                "Seleccione una localidad");
            Con.Close();
        }
    }
}
