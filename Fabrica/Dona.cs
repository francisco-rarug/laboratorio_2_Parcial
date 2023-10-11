using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal class Dona:ChocoDona
    {
        private string harina;
        public Dona(string cacao, string leche, string azucar, string harina) : base(cacao, azucar, leche)
        {
            this.harina = harina;
        }

       
    }
}
