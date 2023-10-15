using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fabrica
{
    public class Operario:Personal
    {
        private string apellido;
        private static List<Operario> operarios = new List<Operario>();

        public static List<Operario> ListaOperarios { get => operarios; set => operarios = value; }
        public Operario(string nombre, string password, Rango rango, string apellido) :base(nombre, password, rango) {
            this.apellido = apellido;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        
    }
}
