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
    public partial class FormAgregarOperario : Form
    {
        public FormAgregarOperario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string password = tbPassword.Text;
            string rango = "Operario";

            BaseDeDatosDAO.GuardarOperario(nombre, apellido, password, rango);
            MessageBox.Show("Operario registrado correctamente", "Registrado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
