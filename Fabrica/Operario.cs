using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Representa un operario en la fábrica, heredando las propiedades y métodos del personal.
    /// </summary>
    public class Operario : Personal
    {
        private string apellido;
        private static List<Operario> operarios = new List<Operario>();

        /// <summary>
        /// Obtiene o establece la lista de operarios en la fábrica.
        /// </summary>
        public static List<Operario> ListaOperarios { get => operarios; set => operarios = value; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Operario"/> con los valores especificados.
        /// </summary>
        /// <param name="nombre">Nombre del operario.</param>
        /// <param name="password">Contraseña del operario.</param>
        /// <param name="rango">Rango del operario en la fábrica.</param>
        /// <param name="apellido">Apellido del operario.</param>
        public Operario(string nombre, string password, Rango rango, string apellido) : base(nombre, password, rango)
        {
            this.apellido = apellido;
        }

        /// <summary>
        /// Obtiene o establece el apellido del operario.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        /// <summary>
        /// Proporciona una representación en texto de la información del operario.
        /// </summary>
        /// <returns>Una cadena que representa al operario.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Usuario}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Rango: {Rango}");
            return sb.ToString();
        }
    }
}

