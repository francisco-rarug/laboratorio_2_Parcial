using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Representa una dona en la fábrica.
    /// </summary>
    public class Dona
    {
        private string relleno;
        private string tipoDeDona;

        private static List<Dona> listaDonas = new List<Dona>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dona"/> con los valores especificados.
        /// </summary>
        /// <param name="relleno">Relleno de la dona.</param>
        /// <param name="tipoDeDona">Tipo de dona (ej. "Glaseada", "De chocolate", etc.)</param>
        public Dona(string relleno, string tipoDeDona)
        {
            this.relleno = relleno;
            this.tipoDeDona = tipoDeDona;
        }

        /// <summary>
        /// Obtiene o establece el relleno de la dona.
        /// </summary>
        public string Relleno { get => relleno; set => relleno = value; }

        /// <summary>
        /// Obtiene o establece el tipo de dona.
        /// </summary>
        public string TipoDeDona { get => tipoDeDona; set => tipoDeDona = value; }

        /// <summary>
        /// Obtiene o establece la lista de donas.
        /// </summary>
        public static List<Dona> ListaDonas { get => listaDonas; set => listaDonas = value; }

        public static Dona CrearDonaDefault()
        {
            string donas = "Glaseadas";
            string relleno = "Dulce de leche";

            if (!Produccion.HayStockSuficiente(donas, relleno, 30, 20))
            {
                throw new Exception("No queda stock");
            }

            Dona dona = new Dona(relleno, donas);
            Dona.ListaDonas.Add(dona);

            Produccion.Stock(donas, relleno);
            return dona;
        }

    }
}

