using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class FormConfig
    {
        string backgroundColor;
        string textColor;

        public FormConfig() 
        { 
        }

        public string BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public string TextColor { get => textColor; set => textColor = value; }



    }
}
