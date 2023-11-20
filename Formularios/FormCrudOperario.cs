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

    public partial class FormCrudOperario : Form
    {
        CambiarColor instancia;
        public FormCrudOperario(CambiarColor instancia)
        {
            InitializeComponent();
            dgOperario.DataSource = BaseDeDatosDAO.LeerOperarios();
            this.instancia = instancia;
            instancia(this);
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
            try
            {
                if (dgOperario.SelectedRows.Count > 0)
                {
                    Operario operario = (Operario)dgOperario.CurrentRow.DataBoundItem;
                    BaseDeDatosDAO.Eliminar(operario.Id);
                    Refrescar();

                    MessageBox.Show("Operario eliminado correctamente", "Operario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgOperario.SelectedRows.Count > 0)
                {
                    Operario operario = (Operario)dgOperario.CurrentRow.DataBoundItem;
                    FormActualizarOperario formActualizarOperario = new FormActualizarOperario(operario.Id);
                    formActualizarOperario.ShowDialog();
                    Refrescar();
                }
            }
            catch(Exception ex) 
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
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
