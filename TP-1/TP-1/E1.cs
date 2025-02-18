using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TP_1
{
    public partial class E1 : Form
    {
        public E1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool isNumber = int.TryParse(name, out int value);
            bool isCurrentName = false;

            foreach (string item in nameList1.Items)
            {
                if (item == name) isCurrentName = true;
            }

            if (name.Trim().Length != 0 && !isNumber && !isCurrentName)
                nameList1.Items.Add(textBox1.Text);
            else MessageBox.Show("ingrese un nombre valido");

            isCurrentName = false;
        }

        private void post_Click(object sender, EventArgs e)
        {
            int itemsSelected = nameList1.SelectedItems.Count;
            if (itemsSelected > 2)
            {
                var selectedItems = nameList1.SelectedItems.Cast<string>().ToList();
                foreach (string item in selectedItems)
                {
                    nameList2.Items.Add(item);
                    nameList1.Items.Remove(item);

                }
            }
            else if (itemsSelected == 1)
            {
                string item = nameList1.Text;
                nameList2.Items.Add(item);
                nameList1.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento");
            }
        }

        private void postAll_Click(object sender, EventArgs e)
        {
            var selectedItems = nameList1.Items.Cast<string>().ToList();
            foreach (string item in selectedItems)
            {
                nameList2.Items.Add(item);

            }
            nameList1.Items.Clear();
        }
    }
}
