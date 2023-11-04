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
    public partial class FormVerStock : Form
    {
        public FormVerStock()
        {
            InitializeComponent();
            dataGridView1.DataSource = Produccion.Materiales.Select(item => new { Componente = item.Key, Cantidad = item.Value }).ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Produccion.Materiales)
            {
                sb.AppendLine($"{item.Key}: {item.Value}");
            }
            string contenido = sb.ToString();
            Archivos.CrearArchivo("Stock", ".xml", contenido);
            MessageBox.Show("El stock actual fue guardado", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
