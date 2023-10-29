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
        /// Inicializa una lista estática de operarios con valores predeterminados.
        /// </summary>
        public static void InicializarOperarios()
        {
            Operario operario1 = new Operario("Martin", "12345", Rango.Operario, "Chacal");
            Operario operario2 = new Operario("Federico", "12345", Rango.Operario, "Galarza");
            Operario operario3 = new Operario("Paola", "12345", Rango.Operario, "Argento");
            Operario operario4 = new Operario("Lauti", "profe", Rango.Operario, "Profe");
            Operario operario5 = new Operario("Lucas", "profe", Rango.Operario, "Profe");
            Operario operario6 = new Operario("Mathi", "profe", Rango.Operario, "Bustamante");

            ListaOperarios.Add(operario1);
            ListaOperarios.Add(operario2);
            ListaOperarios.Add(operario3);
            ListaOperarios.Add(operario4);
            ListaOperarios.Add(operario5);
            ListaOperarios.Add(operario6);
        }

        /// <summary>
        /// Busca un operario por su usuario, contraseña y rango.
        /// </summary>
        /// <param name="usuario">Usuario del operario a buscar.</param>
        /// <param name="password">Contraseña del operario a buscar.</param>
        /// <param name="rango">Rango del operario a buscar.</param>
        /// <returns>Retorna el operario si se encuentra, de lo contrario retorna null.</returns>
        public static Operario BuscarPorUsuarioYRango(string usuario, string password, Rango rango)
        {
            foreach (Operario operario in ListaOperarios)
            {
                if (operario.Autenticar(usuario, password) && operario.Rango == rango)
                {
                    return operario;
                }
            }
            return null;
        }

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

