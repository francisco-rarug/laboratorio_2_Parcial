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
    public partial class VerOperarios : Form
    {
        public VerOperarios()
        {
            InitializeComponent();
            dataOperarios.DataSource = BaseDeDatosDAO.LeerOperarios();
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}


