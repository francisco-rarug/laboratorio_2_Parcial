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
    public partial class FormFabricaOperario : Form
    {
        public FormFabricaOperario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVerStock formVerStock = new FormVerStock();
            Hide();
            DialogResult result = formVerStock.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProductosCreados formProductosCreados = new FormProductosCreados();
            Hide();
            DialogResult result = formProductosCreados.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnDonaDefault_Click(object sender, EventArgs e)
        {
            string donas = "Glaseadas";
            string relleno = "Dulce de leche";


            if (!Produccion.HayStockSuficiente(donas, relleno, 30, 20))
            {
                MessageBox.Show("No queda stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            FormModal1 formProduct = new FormModal1();

            formProduct.ShowDialog();

            Dona dona = new Dona(relleno, donas);
            Dona.ListaDonas.Add(dona);


            Produccion.Stock(donas, relleno);
        }

        private void btnChocoDefault_Click(object sender, EventArgs e)
        {
            string chocolates = "Amargo";
            string tamaños = "2x2";

            if (!Produccion.HayStockSuficiente(chocolates, tamaños, 30, 20))
            {
                MessageBox.Show("No queda stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormModal1 formProduct = new FormModal1();

            formProduct.ShowDialog();

            Chocolate chocolate = new Chocolate(tamaños, chocolates);
            Chocolate.ListaChocolates.Add(chocolate);

            Produccion.Stock(chocolates, tamaños);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCrearProducto formProduct = new FormCrearProducto();
            Hide();
            DialogResult result = formProduct.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }
    }
}
