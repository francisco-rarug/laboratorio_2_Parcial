using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Chocolate:ChocoDona
    {
        private string mani;
        public Chocolate(string cacao, string leche, Rango rango, string azucar, string mani) : base(cacao, leche, azucar)
        {
            this.mani = mani;
        }

    }
}
