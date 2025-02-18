using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class E2 : Form
    {
        public E2()
        {
            InitializeComponent();
        }

        private void NombreValido(string fullName) //Funcion para validar que el nombre y apellido sean validos y no esten repetidos
        {
          
            var selectedItems = fullNameList.SelectedItems.Cast<string>().ToList();

            foreach (string item in selectedItems)
            {
                if(fullName == item.ToUpper()) {
                    MessageBox.Show("El nombre ya se encuentra en la Lista", "Informacion ingresada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error); //Muestra un cartel de error cuando el campo de nombre esta vacio o repetido
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(fullName)) ///Controla que los campos no esten vacios.
            {
                fullNameList.Items.Add(fullName); ///Copia lo del txtName a la fullNameList
                txtName.Clear();
                txtSurname.Clear();
            }
            else
                MessageBox.Show("Complete los campos vacios", "Informacion ingresada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error); //Muestra un cartel de error cuando el campo de nombre esta vacio o repetido
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim() + " " + txtSurname.Text.Trim();

            NombreValido(fullName);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            fullNameList.Items.Clear();
        }
    }
}
