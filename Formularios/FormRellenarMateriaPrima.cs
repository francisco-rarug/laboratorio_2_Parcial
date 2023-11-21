using Fabrica;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public partial class FormRellenarMateriaPrima : Form
    {
        public FormRellenarMateriaPrima()
        {
            InitializeComponent();
        }

        private List<string> productosSeleccionados = new List<string>();


        /// <summary>
        /// Recopila los productos seleccionados en un control GroupBox con CheckBoxes.
        /// </summary>
        /// <param name="groupBox">Control GroupBox que contiene los CheckBoxes de productos.</param>
        private void RecopilarProductosSeleccionados(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    productosSeleccionados.Add(((CheckBox)control).Text);
                }
            }
        }

        /// <summary>
        /// Desmarca todos los CheckBoxes en un control GroupBox.
        /// </summary>
        /// <param name="groupBox">Control GroupBox que contiene los CheckBoxes a desmarcar.</param>
        private void DesmarcarCheckBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }


        private void btnRellenar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = (int)numCantidad.Value;

                productosSeleccionados.Clear();
                RecopilarProductosSeleccionados(gbChocolates);
                RecopilarProductosSeleccionados(gbDonas);

                Produccion.ActualizarMateriales(cantidad, productosSeleccionados);

                MessageBox.Show("Se agregó el stock correctamente", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DesmarcarCheckBoxes(gbChocolates);
                DesmarcarCheckBoxes(gbDonas);
            }catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

