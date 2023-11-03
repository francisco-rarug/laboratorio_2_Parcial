using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Archivos
    {
        static void main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
            string path=$"{Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)}";

            path += @"\Directorio\";
            Console.WriteLine(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Creando directorio....");
            }

            if (Directory.Exists(path))
            {
                Console.WriteLine("el directorio existe...");
                using (StreamWriter sw = new StreamWriter("ArchivoPrueba.txt")) 
                {
                    sw.WriteLine("Linea 1");
                }
            }


        }
    }
}
