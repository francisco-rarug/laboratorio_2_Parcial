using Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            dataGridView1.DataSource = Produccion.ObtenerMaterialesOrdenados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                string directorioPath = @"C:\Users\NoxiePC\source\repos\Rarug.Francisco.Parcial\Archivos\Stock.xml";
                

                List<ComponenteCantidad> datos = new List<ComponenteCantidad>();
                foreach (var item in Produccion.Materiales)
                {
                    var elemento = new ComponenteCantidad(item.Key, item.Value);
                    datos.Add(elemento);
                }

                if (datos != null && datos.Count > 0)
                {
                    var archivosManager = new Archivos<List<ComponenteCantidad>>();
                    archivosManager.Escribir_XML(directorioPath, datos);
                    MessageBox.Show("El stock actual fue guardado en un archivo XML", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("La lista de datos está vacía o nula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
