using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Representa un chocolate en la fábrica.
    /// </summary>
    public class Chocolate:Producto
    {
        private static List<Chocolate> listaChocolates = new List<Chocolate>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Chocolate"/> con los valores especificados.
        /// </summary>
        /// <param name="tamaño">Tamaño del chocolate.</param>
        /// <param name="tipoChocolate">Tipo del chocolate (ej. "Amargo", "Chocolate blanco", etc.)</param>
        public Chocolate(string tamaño, string tipoChocolate) : base(tamaño, tipoChocolate)
        {
        }
        /// <summary>
        /// Obtiene o establece la lista de chocolates.
        /// </summary>
        public static List<Chocolate> ListaChocolates { get => listaChocolates; set => listaChocolates = value; }


        public static bool CrearChocolateDefault(out Chocolate nuevoChocolate)
        {
            string chocolates = "Amargo";
            string tamaños = "2x2";

            if (!Produccion.HayStockSuficiente(chocolates, tamaños, 30, 20))
            {
                nuevoChocolate = null;
                return false;
            }

            nuevoChocolate = new Chocolate(tamaños, chocolates);
            ListaChocolates.Add(nuevoChocolate);

            Produccion.Stock(chocolates, tamaños);

            return true;
        }


    }
}



