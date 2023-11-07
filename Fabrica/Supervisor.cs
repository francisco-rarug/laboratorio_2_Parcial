using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Supervisor : Personal
    {
        private string legajo;
        private static List<Supervisor> supervisor = new List<Supervisor>();

        public static List<Supervisor> ListaSupervisor { get => supervisor; set => supervisor = value; }

        public Supervisor(string usuario, string password, Rango rango, string legajo) : base(usuario, password, rango)
        {
            this.legajo = legajo;
        }

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
            catch(Exception ex)
            {
                Console.WriteLine("Error, no se pudo encontrar el supervisor"+ex.Message);
                return null;
            }
            
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Usuario}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Rango: {Rango}");
            return sb.ToString();
        }
    }
}
