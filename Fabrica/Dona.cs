using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Dona
    {
        private string relleno;
        private string tipoDeDona;

        private static List<Dona> listaDonas = new List<Dona>();

        public Dona(string relleno, string tipoDeDona)
        {
            this.relleno = relleno;
            this.tipoDeDona = tipoDeDona;
        }

        public string Relleno { get => relleno; set => relleno = value; }
        public string TipoDeDona { get => tipoDeDona; set => tipoDeDona = value; }
        public static List<Dona> ListaDonas { get => listaDonas; set => listaDonas = value; }
    }
}
