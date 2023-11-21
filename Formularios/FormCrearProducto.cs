using Fabrica;
using System.Reflection;
namespace Rarug.Francisco.Parcial
{
    public partial class FormCrearProducto : Form
    {
        private delegate bool VerificarStockDelegate(string tipo, string detalle);
        private delegate bool ProductoOperationDelegate(string tipo, string detalle);


        public FormCrearProducto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para crear un producto genérico.
        /// </summary>
        /// <param name="tipoGroupBox">GroupBox que contiene los controles de selección del tipo de producto.</param>
        /// <param name="detalleGroupBox">GroupBox que contiene los controles de selección del detalle del producto.</param>
        /// <param name="verificarStock">Delegado para verificar el stock del producto.</param>
        /// <param name="agregarProductoALista">Delegado para agregar el producto a la lista correspondiente.</param>
        private void CrearProducto(GroupBox tipoGroupBox, GroupBox detalleGroupBox, VerificarStockDelegate verificarStock, ProductoOperationDelegate agregarProductoALista)
        {
            try
            {
                string tipo = ObtenerSeleccion(tipoGroupBox);
                string detalle = ObtenerSeleccion(detalleGroupBox);

                if (!verificarStock(tipo, detalle))
                {
                    MessageBox.Show("No queda stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MostrarFormularioModal();

                agregarProductoALista(tipo, detalle);

                Produccion.Stock(tipo, detalle);
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Método para obtener la selección de un grupo de controles tipo RadioButton.
        /// </summary>
        /// <param name="grupo">GroupBox que contiene los controles RadioButton.</param>
        /// <returns>Texto del control RadioButton seleccionado.</returns>
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

        /// <summary>
        /// Método para mostrar un formulario modal.
        /// </summary>
        /// <returns>Resultado de la operación del formulario modal.</returns>
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
            CrearProducto(gbChocolate, gbTamaño, Chocolate.VerificarStockChocolate, Chocolate.AgregarChocolate);

        }

        private void btnCrearDona_Click_1(object sender, EventArgs e)
        {
            CrearProducto(gbDonas, gbRelleno, Dona.VerificarStockDona, Dona.AgregarDona);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
