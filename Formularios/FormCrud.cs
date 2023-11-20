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
    public delegate void CambiarColor(Form instancia);


    public partial class FormCrud : Form
    {
        Color tema = Color.AliceBlue;
        private Newsletter newsletter;
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
            newsletter.botonOscuro();
        }

        private void btnClaro_Click(object sender, EventArgs e)
        {
            tema = Color.AliceBlue;
            cambiarColor(this);
            newsletter.botonClaro();
        }

        private void MostrarMensajeClaro(object sender, EventArgs e)
        {
            MessageBox.Show("Color oscuro aplicado", "Color Cambiado");
        }

        private void MostrarMensajeOscuro(object sender, EventArgs e)
        {
            MessageBox.Show("Color oscuro aplicado", "Color Cambiado");
        }

        private void FormCrud_Load(object sender, EventArgs e)
        {
            newsletter = new Newsletter();

            newsletter.MensajeClaro += MostrarMensajeClaro;
            newsletter.MensajeOscuro += MostrarMensajeOscuro;
        }
    }
}
