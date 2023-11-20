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
    public partial class FormAgregarSupervisor : Form
    {
        public FormAgregarSupervisor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text;
                string legajo = tbLegajo.Text;
                string password = tbPassword.Text;
                string rango = "Supervisor";

                BaseDeDatosDAO.GuardarSupervisor(nombre, legajo, password, rango);
                MessageBox.Show("Supervisor registrado correctamente", "Registrado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
