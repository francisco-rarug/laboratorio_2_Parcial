using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class ComponenteCantidad
    {
        string componente;
        int cantidad;

        public ComponenteCantidad()
        {
            
        }
        public ComponenteCantidad(string componente, int cantidad)
        {
            this.Componente = componente;
            this.Cantidad = cantidad;
        }

        public string Componente { get => componente; set => componente = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
