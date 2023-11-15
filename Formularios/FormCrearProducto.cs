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

        private void MostrarMensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarFormularioModal()
        {
            using (FormModal1 formProduct = new FormModal1())
            {
                Hide();
                var result = formProduct.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                }
            }
        }

        private void btnCrearChocolate_Click_1(object sender, EventArgs e)
        {
            Chocolate nuevoChocolate;
            CrearProducto(() => Chocolate.CrearChocolateDefault(out nuevoChocolate), "Chocolate creado", "Ha ocurrido un error al crear el chocolate");
        }

        private void btnCrearDona_Click_1(object sender, EventArgs e)
        {
            Dona nuevaDona;
            CrearProducto(() => Dona.CrearDonaDefault(out nuevaDona), "Dona creada", "Ha ocurrido un error al crear la dona");
        }

        private void CrearProducto(Func<bool> crearMetodo, string mensajeExito, string mensajeError)
        {
            try
            {
                if (crearMetodo())
                {
                    MostrarFormularioModal();
                }
                else
                {
                    MostrarMensajeAdvertencia("No queda stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mensajeError + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
