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
        public void CrearProductoDefault(Func<bool> crearMetodo, string exitoMensaje, string errorMensaje)
        {
            try
            {
                if (Crear(crearMetodo))
                {
                    FormModal1 formProduct = new FormModal1();
                    formProduct.ShowDialog();

                    MessageBox.Show($"{exitoMensaje} exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al crear el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Crear(Func<bool> metodo)
        {
            return metodo();
        }

        private void btnDonaDefault_Click(object sender, EventArgs e)
        {
            Chocolate nuevoChocolate;
            CrearProductoDefault(() => Chocolate.CrearChocolateDefault(out nuevoChocolate), "Chocolate creado", "Ha ocurrido un error al crear el chocolate");
        }

        private void btnChocoDefault_Click(object sender, EventArgs e)
        {
            Dona nuevaDona;
            CrearProductoDefault(() => Dona.CrearDonaDefault(out nuevaDona), "Dona creada", "Ha ocurrido un error al crear la dona");
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormProductosCreados formProductosCreados = new FormProductosCreados();
            Hide();
            DialogResult result = formProductosCreados.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            FormVerStock formVerStock = new FormVerStock();
            Hide();
            DialogResult result = formVerStock.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            FormCrearProducto formProduct = new FormCrearProducto();
            Hide();
            DialogResult result = formProduct.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
