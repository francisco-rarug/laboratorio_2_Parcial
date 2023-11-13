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
    public partial class FormActualizarOperario : Form
    {
        private int id;
        public FormActualizarOperario(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string password = tbPassword.Text;

            BaseDeDatosDAO.ModificarOperario(nombre, id, apellido, password);
            MessageBox.Show("Operario Actualizado correctamente", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
