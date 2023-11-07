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
            string directorioPath = @"C:\Users\NoxiePC\source\repos\Rarug.Francisco.Parcial\Archivos";
            string nombreArchivo = "Stock.xml";
            string rutaCompleta = Path.Combine(directorioPath, nombreArchivo);

            List<ComponenteCantidad> datos = new List<ComponenteCantidad>();
            foreach (var item in Produccion.Materiales)
            {
                var elemento = new ComponenteCantidad(item.Key, item.Value);
                datos.Add(elemento);
            }

            Archivos<List<ComponenteCantidad>>.Escribir_XML(rutaCompleta, datos);

            MessageBox.Show("El stock actual fue guardado en un archivo XML", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //StringBuilder sb = new StringBuilder();
            //foreach (var item in Produccion.Materiales)
            //{
            //    sb.AppendLine($"{item.Key}: {item.Value}");
            //}
            //string contenido = sb.ToString();
            //Archivos<string>.CrearArchivo("Stock", "xml", contenido);
            //MessageBox.Show("El stock actual fue guardado", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
