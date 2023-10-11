using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class ChocoDona
    {
        private string cacao;
        private string azucar;
        private string leche;

        public ChocoDona(string cacao, string azucar, string leche)
        {
            this.cacao = cacao;
            this.azucar = azucar;
            this.leche = leche;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cacao: {cacao}");
            sb.AppendLine($"Azucar: {azucar}");
            sb.AppendLine($"Leche: {leche}");

            return sb.ToString();
        }
    }
}
