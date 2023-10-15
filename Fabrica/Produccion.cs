using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Produccion
    {
        public List<MateriaPrima> MateriasPrimas { get; set; }

        public Produccion()
        {
            MateriasPrimas = new List<MateriaPrima>();
            MateriasPrimas.Add(new MateriaPrima("Cacao", 1000)); 
            MateriasPrimas.Add(new MateriaPrima("Azúcar", 1500));
            
        }
        public void ProducirChocolate(string tipoChocolate)
        {
            switch (tipoChocolate)
            {
                case "Chocolate Amargo":
                    foreach (MateriaPrima materia in MateriasPrimas)
                    {
                        if (materia.Nombre == "Cacao")
                        {
                            materia.Consumir(10);
                            break;  
                        }
                    }
                    break;
                case "Chocolate con Leche":
                    foreach (MateriaPrima materia in MateriasPrimas)
                    {
                        if (materia.Nombre == "Cacao")
                        {
                            materia.Consumir(5);
                            break; 
                        }
                    }
                    break;


            }
        }
    }

}
