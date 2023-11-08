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
        public FormCrudSupervisor()
        {
            InitializeComponent();
            dgSupervisor.DataSource = BaseDeDatosDAO.LeerSupervisor();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FormActualizarSupervisor formAgregarSupervisor = new FormActualizarSupervisor();
            //Hide();
            //DialogResult result = formAgregarSupervisor.ShowDialog();
            //if (result == DialogResult.Cancel) Show();
            //return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)dgSupervisor.CurrentRow.DataBoundItem;
                BaseDeDatosDAO.EliminarSupervisor(supervisor.Id);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)dgSupervisor.CurrentRow.DataBoundItem;
                FormActualizarSupervisor formAgregarOperario = new FormActualizarSupervisor(supervisor.Id);
                formAgregarOperario.Show();

            }
        }
    }
}
