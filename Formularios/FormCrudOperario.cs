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

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    FormAgregarOperario formAgregarOperario = new FormAgregarOperario();
        //    Hide();
        //    DialogResult result = formAgregarOperario.ShowDialog();
        //    if (result == DialogResult.Cancel) Show();
        //    return;
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)dgOperario.CurrentRow.DataBoundItem;
                BaseDeDatosDAO.EliminarOperario(operario.Id);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)dgOperario.CurrentRow.DataBoundItem;
                FormActualizarOperario formAgregarOperario = new FormActualizarOperario(operario.Id);
                formAgregarOperario.Show();
                
            }
        }
    }
}
