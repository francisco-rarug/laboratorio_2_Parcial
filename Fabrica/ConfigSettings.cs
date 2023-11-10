using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class ConfigSettings
    {
        private string botonRellenarStock;
        private string botonCrearChocolate;
        private string botonCrud;
        private string botonVerStock;
        private string botonVerProductos;
        private string botonOperariosConectados;
        private string botonCerrar;
        private string botonCrearProducto;
        private string botonCrearDona;
        private string labelTitulo;
        private string form;
        private string botonModoOscuro;
        private string botonModoClaro;

        public string BotonRellenarStock { get => botonRellenarStock; set => botonRellenarStock = value; }
        public string BotonCrearChocolate { get => botonCrearChocolate; set => botonCrearChocolate = value; }
        public string BotonCrud { get => botonCrud; set => botonCrud = value; }
        public string BotonVerProductos { get => botonVerProductos; set => botonVerProductos = value; }
        public string BotonOperariosConectados { get => botonOperariosConectados; set => botonOperariosConectados = value; }
        public string BotonCerrar { get => botonCerrar; set => botonCerrar = value; }
        public string BotonCrearProducto { get => botonCrearProducto; set => botonCrearProducto = value; }
        public string BotonCrearDona { get => botonCrearDona; set => botonCrearDona = value; }
        public string LabelTitulo { get => labelTitulo; set => labelTitulo = value; }
        public string Form { get => form; set => form = value; }
        public string BotonModoOscuro { get => botonModoOscuro; set => botonModoOscuro = value; }
        public string BotonModoClaro { get => botonModoClaro; set => botonModoClaro = value; }
        public string BotonVerStock { get => botonVerStock; set => botonVerStock = value; }
    }
}
