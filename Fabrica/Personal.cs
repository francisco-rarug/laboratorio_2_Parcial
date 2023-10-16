using System.Text;

namespace Fabrica
{
    /// <summary>
    /// Enumeración que define los rangos posibles para el personal en la fábrica.
    /// </summary>
    public enum Rango
    {
        /// <summary>
        /// Representa un empleado con rango de operario.
        /// </summary>
        Operario,

        /// <summary>
        /// Representa un empleado con rango de supervisor.
        /// </summary>
        Supervisor
    }

    /// <summary>
    /// Clase base abstracta que define las propiedades y comportamientos comunes para el personal de la fábrica.
    /// </summary>
    public abstract class Personal
    {
        private string usuario;
        private string password;
        private Rango rango;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Personal"/> con los valores especificados.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del personal.</param>
        /// <param name="password">Contraseña asociada al nombre de usuario.</param>
        /// <param name="rango">Rango o nivel de autoridad del empleado.</param>
        public Personal(string usuario, string password, Rango rango)
        {
            this.usuario = usuario;
            this.password = password;
            this.rango = rango;
        }

        /// <summary>
        /// Obtiene o establece el nombre de usuario del personal.
        /// </summary>
        public string Usuario { get => usuario; set => usuario = value; }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario.
        /// </summary>
        public string Password { get => password; set => password = value; }

        /// <summary>
        /// Obtiene o establece el rango o nivel de autoridad del empleado.
        /// </summary>
        public Rango Rango { get => rango; set => rango = value; }

        /// <summary>
        /// Método abstracto para mostrar información del personal. Las clases derivadas deben implementar este método.
        /// </summary>
        /// <returns>Una cadena que representa la información del personal.</returns>
        public abstract string Mostrar();
    }
}



