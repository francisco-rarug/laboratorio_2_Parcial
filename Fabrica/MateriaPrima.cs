using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class MateriaPrima
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }

        public MateriaPrima(string nombre, double cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
        public void Consumir(double cantidadAConsumir)
        {
            Cantidad -= cantidadAConsumir;
        }
    }

}

