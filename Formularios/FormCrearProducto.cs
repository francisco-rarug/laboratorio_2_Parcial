using Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rarug.Francisco.Parcial
{


    public partial class FormCrearProducto : Form
    {
        public FormCrearProducto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearChocolate_Click_1(object sender, EventArgs e)
        {
            string chocolates = string.Empty;

            foreach (Control item in gbChocolate.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    chocolates = ((RadioButton)item).Text;
                }
            }
            MessageBox.Show(chocolates);

            FormModal1 formProduct = new FormModal1();
            Hide();
            DialogResult result = formProduct.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnCrearDona_Click(object sender, EventArgs e)
        {

        }
    }
}