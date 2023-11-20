using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public delegate void MensajeEventHandler(object sender, EventArgs e);

    public class Newsletter
    {

        public event MensajeEventHandler MensajeClaro;

        public event MensajeEventHandler MensajeOscuro;

        public void botonClaro()
        {
            mensajeClaro();
        }

        public void botonOscuro()
        {
            mensajeOscuro();
        }

        protected virtual void mensajeClaro()
        {
            MensajeClaro.Invoke(this, EventArgs.Empty);
        }

        protected virtual void mensajeOscuro()
        {
            MensajeOscuro.Invoke(this, EventArgs.Empty);
        }
    }
}
