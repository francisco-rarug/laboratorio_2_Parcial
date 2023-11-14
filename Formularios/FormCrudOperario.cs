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
    public partial class FormCrudOperario : Form
    {
        public FormCrudOperario()
        {
            InitializeComponent();
            dgOperario.DataSource = BaseDeDatosDAO.LeerOperarios();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Refrescar()
        {
            dgOperario.DataSource = null;
            dgOperario.DataSource = BaseDeDatosDAO.LeerOperarios();
            dgOperario.Refresh();
            dgOperario.Update();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)dgOperario.CurrentRow.DataBoundItem;
                BaseDeDatosDAO.EliminarOperario(operario.Id);
                Refrescar();

                MessageBox.Show("Operario eliminado correctamente", "Operario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)dgOperario.CurrentRow.DataBoundItem;
                FormActualizarOperario formActualizarOperario = new FormActualizarOperario(operario.Id);
                formActualizarOperario.ShowDialog();
                Refrescar();
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FormAgregarOperario formAgregarOperario = new FormAgregarOperario();
            formAgregarOperario.ShowDialog();
            Refrescar();
        }
    }
}
