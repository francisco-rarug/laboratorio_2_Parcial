using System.Collections.Generic;

namespace Fabrica
{
    /// <summary>
    /// Representa un producto en la fábrica.
    /// </summary>
    public class Producto
    {
        private string tipo;
        private string detalle;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Producto"/> con los valores especificados.
        /// </summary>
        /// <param name="detalle">Detalle del producto (ej. tamaño, relleno, etc.)</param>
        /// <param name="tipo">Tipo del producto.</param>
        public Producto(string detalle, string tipo)
        {
            this.detalle = detalle;
            this.tipo = tipo;
        }

        /// <summary>
        /// Obtiene o establece el detalle del producto.
        /// </summary>
        public string Detalle { get => detalle; set => detalle = value; }

        /// <summary>
        /// Obtiene o establece el tipo del producto.
        /// </summary>
        public string Tipo { get => tipo; set => tipo = value; }
    }
}

