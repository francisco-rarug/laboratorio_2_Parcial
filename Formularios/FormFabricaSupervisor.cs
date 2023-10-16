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

        private void button7_Click(object sender, EventArgs e)
        {

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
            FormVerMateriaPrima form = new FormVerMateriaPrima();
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
    }
}
