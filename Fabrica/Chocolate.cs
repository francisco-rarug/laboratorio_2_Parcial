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
    public class Chocolate
    {
        private string tamaño;
        private string tipoChocolate;

        private static List<Chocolate> listaChocolates = new List<Chocolate>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Chocolate"/> con los valores especificados.
        /// </summary>
        /// <param name="tamaño">Tamaño del chocolate.</param>
        /// <param name="tipoChocolate">Tipo del chocolate (ej. "Amargo", "Chocolate blanco", etc.)</param>
        public Chocolate(string tamaño, string tipoChocolate)
        {
            this.tamaño = tamaño;
            this.tipoChocolate = tipoChocolate;
        }

        /// <summary>
        /// Obtiene o establece el tamaño del chocolate.
        /// </summary>
        public string Tamaño { get => tamaño; set => tamaño = value; }

        /// <summary>
        /// Obtiene o establece la lista de chocolates.
        /// </summary>
        public static List<Chocolate> ListaChocolates { get => listaChocolates; set => listaChocolates = value; }

        /// <summary>
        /// Obtiene o establece el tipo del chocolate.
        /// </summary>
        public string TipoChocolate { get => tipoChocolate; set => tipoChocolate = value; }
    }
}

