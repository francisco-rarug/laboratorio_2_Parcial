using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Supervisor : Personal
    {
        private string legajo;
        private static List<Supervisor> supervisor = new List<Supervisor>();

        public static List<Supervisor> ListaSupervisor { get => supervisor; set => supervisor = value; }

        public Supervisor(string usuario, string password, Rango rango, string legajo, int id) : base(usuario, password, rango, id)
        {
            this.legajo = legajo;
        }
        public string Legajo { get => legajo; set => legajo = value; }

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
