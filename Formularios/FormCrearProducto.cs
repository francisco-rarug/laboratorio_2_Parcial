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
    public partial class FormCrearProducto : Form
    {
        public FormCrearProducto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckAndUpdateProgressBar(RadioButton radioButton, ProgressBar progressBar)
        {
            if (radioButton.Checked && progressBar.Value > 0)
            {
                progressBar.Value -= 10;

                if (progressBar.Value == 0)
                {
                    MessageBox.Show("¡Te quedaste sin stock!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCrearChocolate_Click_1(object sender, EventArgs e)
        {
            CheckAndUpdateProgressBar(radioButton1, progressBar1);
            CheckAndUpdateProgressBar(radioButton2, progressBar2);
            CheckAndUpdateProgressBar(radioButton3, progressBar3);
            CheckAndUpdateProgressBar(radioButton4, progressBar4);
        }

        private void btnCrearDona_Click(object sender, EventArgs e)
        {
            CheckAndUpdateProgressBar(radioButton5, progressBar5);
            CheckAndUpdateProgressBar(radioButton6, progressBar6);
            CheckAndUpdateProgressBar(radioButton7, progressBar7);
            CheckAndUpdateProgressBar(radioButton8, progressBar8);
        }
    }
}


