using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Rarug.Francisco.Parcial
{
    public partial class FormModal1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public FormModal1()
        {
            InitializeComponent();

            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Maximum;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value > 0)
            {
                progressBar1.Value--;
            }

            timer.Stop();

            FormModal2 form2 = new FormModal2();

            this.Hide();
            form2.ShowDialog();

            this.Close();
        }

        private void FormModal1_Load(object sender, EventArgs e)
        {

        }
    }
}
