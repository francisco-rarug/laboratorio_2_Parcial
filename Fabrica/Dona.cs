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
    public class Dona : Producto
    {
        private static List<Dona> listaDonas = new List<Dona>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dona"/> con los valores especificados.
        /// </summary>
        /// <param name="relleno">Relleno de la dona.</param>
        /// <param name="tipoDeDona">Tipo de dona (ej. "Glaseada", "De chocolate", etc.)</param>
        public Dona(string relleno, string tipoDeDona) : base(relleno, tipoDeDona)
        {
        }

        /// <summary>
        /// Obtiene o establece la lista de donas.
        /// </summary>
        public static List<Dona> ListaDonas { get => listaDonas; set => listaDonas = value; }

        /// <summary>
        /// Crea una nueva dona por defecto y la agrega a la lista de donas.
        /// </summary>
        /// <param name="nuevaDona">La nueva dona creada.</param>
        /// <returns>True si se crea y agrega correctamente, False si no hay suficiente stock.</returns>
        public static bool CrearDonaDefault(out Dona nuevaDona)
        {
            string donas = "Glaseadas";
            string relleno = "Dulce de leche";

            if (!Produccion.HayStockSuficiente(donas, relleno, 30, 20))
            {
                throw new Exception("No queda stock");
            }

            nuevaDona = new Dona(relleno, donas);
            ListaDonas.Add(nuevaDona);

            Produccion.Stock(donas, relleno);
            return true;
        }

        /// <summary>
        /// Verifica si hay suficiente stock de un tipo específico de dona.
        /// </summary>
        /// <param name="tipo">Tipo de dona.</param>
        /// <param name="detalle">Detalle de la dona.</param>
        /// <returns>True si hay suficiente stock, False en caso contrario.</returns>
        public static bool VerificarStockDona(string tipo, string detalle)
        {
            return Produccion.HayStockSuficiente(tipo, detalle, 30, 20);
        }

        /// <summary>
        /// Agrega una nueva dona a la lista de donas.
        /// </summary>
        /// <param name="tipo">Tipo de dona.</param>
        /// <param name="detalle">Detalle de la dona.</param>
        /// <returns>True si se agrega correctamente.</returns>
        public static bool AgregarDona(string tipo, string detalle)
        {
            ListaDonas.Add(new Dona(detalle, tipo));
            return true;
        }
    }
}

