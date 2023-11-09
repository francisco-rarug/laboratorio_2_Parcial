using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class ConfigSettings
    {
        private string botonIngresar;
        private string botonCerrar;
        private string botonHardOperario;
        private string botonHardSupervisor;
        private string labelTitulo;


        public string BotonIngresar { get => botonIngresar; set => botonIngresar = value; }
        public string BotonCerrar { get => botonCerrar; set => botonCerrar = value; }
        public string BotonHardOperario { get => botonHardOperario; set => botonHardOperario = value; }
        public string BotonHardSupervisor { get => botonHardSupervisor; set => botonHardSupervisor = value; }
        public string LabelTitulo { get => labelTitulo; set => labelTitulo = value; }
    }
}
