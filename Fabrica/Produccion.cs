using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Produccion
    {

        private static Dictionary<string, int> Materiales = new Dictionary<string, int>()
        {
            {"chocolate blanco", 100 },
            {"chocolate amargo", 100 },
            {"chocolate vegano", 100 },
            {"chocolate con mani", 50 },
        };

        public static Dictionary<string, int> Materiales1 { get => Materiales; set => Materiales = value; }

        public static bool Stock(string tipoChocolate)
        {

            foreach (var componente in Materiales)
            {
                if (componente.Key == tipoChocolate && componente.Value > 0 )
                {
                    Materiales[componente.Key]--;
                    return true;
                }
            }
            
            return false;

           
        } 
    }

}
