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
    public partial class FormFabricaSupervisor : Form

    {
        public FormFabricaSupervisor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCrearProducto formProduct = new FormCrearProducto();
            Hide();
            DialogResult result = formProduct.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }
        private void buttonOperariosConectados_Click(object sender, EventArgs e)
        {
            VerOperarios formOperarios = new VerOperarios();
            Hide();
            DialogResult result = formOperarios.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVerStock form = new FormVerStock();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProductosCreados formProductosCreados = new FormProductosCreados();
            formProductosCreados.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormRellenarMateriaPrima rellenarMateriaPrima = new FormRellenarMateriaPrima();
            rellenarMateriaPrima.Show();
        }

        private void btnChocolateDefault_Click(object sender, EventArgs e)
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
    }
}



