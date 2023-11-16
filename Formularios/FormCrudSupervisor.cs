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
    public partial class FormCrudSupervisor : Form
    {
        CambiarColor instancia;
        public FormCrudSupervisor(CambiarColor instancia)
        {
            InitializeComponent();
            dgSupervisor.DataSource = BaseDeDatosDAO.LeerSupervisor();
            this.instancia = instancia;
            instancia(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refrescar()
        {
            dgSupervisor.DataSource = null;
            dgSupervisor.DataSource = BaseDeDatosDAO.LeerSupervisor();
            dgSupervisor.Refresh();
            dgSupervisor.Update();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarSupervisor formAgregarSupervisor = new FormAgregarSupervisor();
            formAgregarSupervisor.ShowDialog();
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)dgSupervisor.CurrentRow.DataBoundItem;
                BaseDeDatosDAO.EliminarSupervisor(supervisor.Id);
                Refrescar();

                MessageBox.Show("Supervisor eliminado correctamente", "Supervisor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)dgSupervisor.CurrentRow.DataBoundItem;
                FormActualizarSupervisor formActualizarSupervisor = new FormActualizarSupervisor(supervisor.Id);
                formActualizarSupervisor.ShowDialog();
                Refrescar();
            }
        }
    }
}
