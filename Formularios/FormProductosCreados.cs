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
    public partial class FormProductosCreados : Form
    {
        public FormProductosCreados()
        {
            InitializeComponent();
            dataGridView1.DataSource = Chocolate.ListaChocolates;
            dataGridView2.DataSource = Dona.ListaDonas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
