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
    public partial class FormCrud : Form
    {
        public FormCrud()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrudSuper_Click(object sender, EventArgs e)
        {
            FormCrudSupervisor formCrudSupervisor = new FormCrudSupervisor();
            Hide();
            DialogResult result = formCrudSupervisor.ShowDialog();
            if (result == DialogResult.Cancel) Show();
            return;
        }

        private void btnCrudOper_Click(object sender, EventArgs e)
        {
            FormCrudOperario formCrudOperario = new FormCrudOperario();
            Hide();
            DialogResult result = formCrudOperario.ShowDialog();
            if (result == DialogResult.Cancel) Show();
            return;
        }
    }
}
