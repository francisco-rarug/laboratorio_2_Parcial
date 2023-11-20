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
            try
            {
                if (dgSupervisor.SelectedRows.Count > 0)
                {
                    Supervisor supervisor = (Supervisor)dgSupervisor.CurrentRow.DataBoundItem;
                    BaseDeDatosDAO.Eliminar(supervisor.Id, "SUPERVISOR");
                    Refrescar();

                    MessageBox.Show("Supervisor eliminado correctamente", "Supervisor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSupervisor.SelectedRows.Count > 0)
                {
                    Supervisor supervisor = (Supervisor)dgSupervisor.CurrentRow.DataBoundItem;
                    FormActualizarSupervisor formActualizarSupervisor = new FormActualizarSupervisor(supervisor.Id);
                    formActualizarSupervisor.ShowDialog();
                    Refrescar();
                }

            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }
    }
}
