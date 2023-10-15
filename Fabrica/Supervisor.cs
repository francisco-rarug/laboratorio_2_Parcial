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
        private static List<Supervisor> supervisor = new List<Supervisor>();

        public static List<Supervisor> ListaSupervisor { get => supervisor; set => supervisor = value; }

        public Supervisor(string nombre, string password, Rango rango, string legajo) : base(nombre, password, rango)
        {
            this.legajo =legajo ;
        }

    }
}
