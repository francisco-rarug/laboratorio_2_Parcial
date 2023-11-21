using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Representa a un operario en la fábrica.
    /// </summary>
    public class Operario : Personal
    {
        private string apellido;

        private static List<Operario> operarios = new List<Operario>();

        /// <summary>
        /// Obtiene o establece la lista de operarios.
        /// </summary>
        public static List<Operario> ListaOperarios { get => operarios; set => operarios = value; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Operario"/> con los valores especificados.
        /// </summary>
        /// <param name="nombre">Nombre del operario.</param>
        /// <param name="password">Contraseña del operario.</param>
        /// <param name="rango">Rango del operario.</param>
        /// <param name="apellido">Apellido del operario.</param>
        /// <param name="id">ID del operario.</param>
        public Operario(string nombre, string password, Rango rango, string apellido, int id) : base(nombre, password, rango, id)
        {
            this.apellido = apellido;
        }

        /// <summary>
        /// Obtiene o establece el apellido del operario.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        /// <summary>
        /// Busca un operario por usuario, contraseña y rango en una lista de personal.
        /// </summary>
        /// <param name="usuario">Usuario a buscar.</param>
        /// <param name="password">Contraseña a verificar.</param>
        /// <param name="rango">Rango del operario.</param>
        /// <param name="listaPersonal">Lista de personal donde buscar.</param>
        /// <returns>El operario encontrado, o null si no se encuentra.</returns>
        public static Operario BuscarPorUsuarioYRango(string usuario, string password, Rango rango, List<Operario> listaPersonal)
        {
            try
            {
                foreach (Operario operario in listaPersonal)
                {
                    if (operario.Autenticar(operario.Usuario, operario.Password, usuario, password) && operario.Rango == rango)
                    {
                        return operario;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Muestra información sobre el operario.
        /// </summary>
        /// <returns>Información formateada del operario.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Usuario}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Rango: {Rango}");
            return sb.ToString();
        }
    }
}
