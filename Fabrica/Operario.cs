using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{

    public class Operario : Personal
    {
        private string apellido;
        private static List<Operario> operarios = new List<Operario>();

        public static List<Operario> ListaOperarios { get => operarios; set => operarios = value; }


        public Operario(string nombre, string password, Rango rango, string apellido) : base(nombre, password, rango)
        {
            this.apellido = apellido;
        }

        public string Apellido { get => apellido; set => apellido = value; }

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
            catch(Exception ex)
            {
                Console.WriteLine("Error, no se encontro el operario"+ex.Message);
                return null;
            }
            
        }

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

