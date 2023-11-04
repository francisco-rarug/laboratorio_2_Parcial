using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Archivos
    {
       public static void CrearArchivo(string nombre, string extension, string informacion)
        {
            string directorioPath = @"C:\Users\NoxiePC\source\repos\Rarug.Francisco.Parcial\Archivos";

            if (!Directory.Exists(directorioPath))
            {
                Directory.CreateDirectory(directorioPath);
            }

            if (Directory.Exists(directorioPath))
            {
                string archivo = $"{directorioPath}/{nombre}.{extension}";
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(informacion);
                }
            }
            
        }
    }
}
