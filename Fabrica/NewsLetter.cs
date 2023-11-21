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

        public event MensajeEventHandler MensajeDona;

        public event MensajeEventHandler MensajeChocolate;

        public void botonDonaDefault()
        {
            mensajeDona();
        }

        public void botonChocolateDefault()
        {
            mensajeChocolate();
        }

        protected virtual void mensajeDona()
        {
            MensajeDona.Invoke(this, EventArgs.Empty);
        }

        protected virtual void mensajeChocolate()
        {
            MensajeChocolate.Invoke(this, EventArgs.Empty);
        }
    }
}
