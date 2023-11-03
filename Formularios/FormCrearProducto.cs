using Fabrica;
using System;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public partial class FormCrearProducto : Form
    {
        public FormCrearProducto()
        {
            InitializeComponent();
        }

        private string ObtenerSeleccion(GroupBox grupo)
        {
            foreach (Control item in grupo.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    return ((RadioButton)item).Text;
                }
            }
            return string.Empty;
        }

        private DialogResult MostrarFormularioModal()
        {
            using (FormModal1 formProduct = new FormModal1())
            {
                Hide();
                var result = formProduct.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                }
                return result;
            }
        }

        private void btnCrearChocolate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string chocolates = ObtenerSeleccion(gbChocolate);
                string tamaños = ObtenerSeleccion(gbTamaño);

                if (!Produccion.HayStockSuficiente(chocolates, tamaños, 30, 20))
                {
                    MessageBox.Show("No queda stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MostrarFormularioModal();

                Chocolate chocolate = new Chocolate(tamaños, chocolates);
                Chocolate.ListaChocolates.Add(chocolate);

                Produccion.Stock(chocolates, tamaños);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al crear el chocolate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearDona_Click_1(object sender, EventArgs e)
        {
            try
            {
                string donas = ObtenerSeleccion(gbDonas);
                string relleno = ObtenerSeleccion(gbRelleno);

                if (!Produccion.HayStockSuficiente(donas, relleno, 30, 20))
                {
                    MessageBox.Show("No queda stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MostrarFormularioModal();

                Dona dona = new Dona(relleno, donas);
                Dona.ListaDonas.Add(dona);

                Produccion.Stock(donas, relleno);
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Ha ocurrido un error al crear la dona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
