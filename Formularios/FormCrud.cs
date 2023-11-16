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
    public delegate void CambiarColor(Form instancia);

    
    public partial class FormCrud : Form
    {
        Color tema = Color.AliceBlue;
        public FormCrud()
        {
            InitializeComponent();
        }

        private void cambiarColor(Form instancia)
        {
            instancia.BackColor = tema;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrudSuper_Click(object sender, EventArgs e)
        {
            FormCrudSupervisor formCrudSupervisor = new FormCrudSupervisor(cambiarColor);
            Hide();
            DialogResult result = formCrudSupervisor.ShowDialog();
            if (result == DialogResult.Cancel) Show();
            return;
        }

        private void btnCrudOper_Click(object sender, EventArgs e)
        {
            FormCrudOperario formCrudOperario = new FormCrudOperario(cambiarColor);
            Hide();
            DialogResult result = formCrudOperario.ShowDialog();
            if (result == DialogResult.Cancel) Show();
            return;
        }

        private void btnOscuro_Click(object sender, EventArgs e)
        {
            tema = Color.Gray;
            cambiarColor(this);
        }

        private void btnClaro_Click(object sender, EventArgs e)
        {
            tema = Color.AliceBlue;
            cambiarColor(this);
        }
    }
}
