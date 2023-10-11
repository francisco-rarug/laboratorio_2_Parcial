using System.Text;

namespace Fabrica
{
    public enum Rango
    {
        Operario,
        Supervisor
    }

    public class Personal
    {
        private string usuario;
        private string password;
        private Rango rango;

        public Personal(string usuario, string password, Rango rango)
        {
            this.usuario = usuario;
            this.password = password;
            this.rango = rango;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public Rango Rango { get => rango; set => rango = value; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Usuario: {usuario}");
            sb.AppendLine($"Password: {password}");
            sb.AppendLine($"Rango: {rango}");

            return sb.ToString();
        }
    }
}

