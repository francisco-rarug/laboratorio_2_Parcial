using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Supervisor:Personal
    {
        private string legajo;
        public Supervisor(string nombre, string password, Rango rango, string apellido) : base(nombre, password, rango)
        {
            this.legajo = apellido;
        }
    }
}
