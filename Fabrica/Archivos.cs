using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fabrica
{
    public class Archivos<T>
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
                string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string archivo = $"{directorioPath}/{nombre}.{extension}"; 
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(fechaHora);
                    sw.WriteLine(informacion);
                }
            }
            
        }
        public static void EscribirJson<T>(string path, T objeto)
        {
            string directorio = Path.GetDirectoryName(path);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(objeto, options);

            File.WriteAllText(path, jsonString);
        }

        public static T Leer_JSON<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            T objeto = JsonSerializer.Deserialize<T>(jsonString);

            return objeto;
        }

        public static void Escribir_XML<T>(string path, T objeto)
        {
            string directorio = Path.GetDirectoryName(path);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, objeto);
            }
        }

        public static T Leer_XML<T>(string path)
        {

            using (StreamReader sw = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(sw);
            }
        }
        
    }
}


