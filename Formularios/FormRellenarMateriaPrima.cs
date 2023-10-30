using Fabrica;
using System;
using System.Collections.Generic;
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
            int cantidad = (int)numCantidad.Value;

            productosSeleccionados.Clear();
            RecopilarProductosSeleccionados(gbChocolates);
            RecopilarProductosSeleccionados(gbDonas);

            foreach (string producto in productosSeleccionados)
            {
                foreach (string clave in Produccion.Materiales.Keys)
                {
                    if (producto == clave)
                    {
                        Produccion.Materiales[producto] += cantidad;
                        break;
                    }
                }
            }

            MessageBox.Show("Se agregó el stock correctamente", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesmarcarCheckBoxes(gbChocolates);
            DesmarcarCheckBoxes(gbDonas);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

