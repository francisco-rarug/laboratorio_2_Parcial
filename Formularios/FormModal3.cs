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
    public partial class FormModal3 : Form
    {
        private System.Windows.Forms.Timer timer;
        public FormModal3()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Maximum;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            Finalizado form4 = new Finalizado();
            timer.Stop();

            Hide();
            DialogResult result = form4.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
            this.Close();
        }
    }
}
