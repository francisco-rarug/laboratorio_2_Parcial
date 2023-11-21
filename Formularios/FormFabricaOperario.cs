using Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public partial class FormFabricaOperario : Form
    {
        private Newsletter newsletter;
        public FormFabricaOperario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crea un producto utilizando un método específico y muestra un mensaje de éxito o error.
        /// </summary>
        /// <param name="crearMetodo">Función que realiza la creación del producto y devuelve un resultado booleano.</param>
        /// <param name="exitoMensaje">Mensaje a mostrar en caso de éxito.</param>
        /// <param name="errorMensaje">Mensaje a mostrar en caso de error.</param>
        public void CrearProductoDefault(Func<bool> crearMetodo)
        {
            try
            {
                if (crearMetodo())
                {
                    FormModal1 formProduct = new FormModal1();
                    formProduct.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnDonaDefault_Click(object sender, EventArgs e)
        {
            Chocolate nuevoChocolate;
            CrearProductoDefault(() => Chocolate.CrearChocolateDefault(out nuevoChocolate));
            newsletter.botonDonaDefault();
        }

        private void btnChocoDefault_Click(object sender, EventArgs e)
        {
            Dona nuevaDona;
            CrearProductoDefault(() => Dona.CrearDonaDefault(out nuevaDona));
            newsletter.botonChocolateDefault();
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

        private void MostrarMensajeDona(object sender, EventArgs e)
        {
            MessageBox.Show("Dona creada", "Producto default");
        }

        private void MostrarMensajeChocolate(object sender, EventArgs e)
        {
            MessageBox.Show("Chocolate creado", "Producto default");
        }

        private void FormFabricaOperario_Load(object sender, EventArgs e)
        {
            newsletter = new Newsletter();

            newsletter.MensajeDona += MostrarMensajeDona;
            newsletter.MensajeChocolate += MostrarMensajeChocolate;
        }
    }
}
