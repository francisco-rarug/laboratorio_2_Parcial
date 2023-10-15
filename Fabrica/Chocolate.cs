using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Chocolate
    {
        private string tamaño;
        private string tipoChocolate;
        
        private static List<Chocolate> listaChocolates = new List<Chocolate>();

        public Chocolate(string tamaño, string tipoChocolate)
        {
            this.tamaño = tamaño;
            this.tipoChocolate = tipoChocolate;
        }

        public string Tamaño { get => tamaño; set => tamaño = value; }
        public static List<Chocolate> ListaChocolates { get => listaChocolates; set => listaChocolates = value; }
        public string TipoChocolate { get => tipoChocolate; set => tipoChocolate = value; }
    }
}
