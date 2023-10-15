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
    public partial class FormModal2 : Form
    {
        private System.Windows.Forms.Timer _timer;
        public FormModal2()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Maximum;
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 2000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value--;
            }

            _timer.Stop();

            FormModal3 form2 = new FormModal3();

            this.Hide();
            form2.ShowDialog();

            this.Close();
        }
    }
}

