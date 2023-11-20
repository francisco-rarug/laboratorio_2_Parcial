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
