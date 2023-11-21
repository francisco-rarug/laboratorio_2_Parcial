using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Representa a un supervisor en la fábrica.
    /// </summary>
    public class Supervisor : Personal
    {
        private string legajo;
        private static List<Supervisor> supervisor = new List<Supervisor>();

        /// <summary>
        /// Obtiene o establece la lista de supervisores.
        /// </summary>
        public static List<Supervisor> ListaSupervisor { get => supervisor; set => supervisor = value; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Supervisor"/> con los valores especificados.
        /// </summary>
        /// <param name="usuario">Usuario del supervisor.</param>
        /// <param name="password">Contraseña del supervisor.</param>
        /// <param name="rango">Rango del supervisor.</param>
        /// <param name="legajo">Legajo del supervisor.</param>
        /// <param name="id">ID del supervisor.</param>
        public Supervisor(string usuario, string password, Rango rango, string legajo, int id) : base(usuario, password, rango, id)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Obtiene o establece el legajo del supervisor.
        /// </summary>
        public string Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Busca un supervisor por usuario, contraseña y rango en una lista de personal.
        /// </summary>
        /// <param name="usuario">Usuario a buscar.</param>
        /// <param name="password">Contraseña a verificar.</param>
        /// <param name="rango">Rango del supervisor.</param>
        /// <param name="listaPersonal">Lista de personal donde buscar.</param>
        /// <returns>El supervisor encontrado, o null si no se encuentra.</returns>
        public static Supervisor BuscarPorUsuarioYRango(string usuario, string password, Rango rango, List<Supervisor> listaPersonal)
        {
            try
            {
                foreach (Supervisor supervisor in listaPersonal)
                {
                    if (supervisor.Autenticar(supervisor.Usuario, supervisor.Password, usuario, password) && supervisor.Rango == rango)
                    {
                        return supervisor;
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
        /// Muestra información sobre el supervisor.
        /// </summary>
        /// <returns>Información formateada del supervisor.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Usuario}");
            sb.AppendLine($"Legajo: {Legajo}");
            sb.AppendLine($"Rango: {Rango}");
            return sb.ToString();
        }
    }
}
