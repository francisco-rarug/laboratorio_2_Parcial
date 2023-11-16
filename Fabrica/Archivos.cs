using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fabrica
{
    public class Archivos<T> : Iarchivos<T>
    {

        public bool Escribir_TXT(string path, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(datos);
                }
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void EscribirJson(string path, T objeto)
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

        public T Leer_JSON<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            T objeto = JsonSerializer.Deserialize<T>(jsonString);
            return objeto;
        }

        public void Escribir_XML(string path, T objeto)
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

        public T LeerXml(string path)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(sw);
            }
        }


        public static void Errores(DateTime fechaYhora, string clase, string metodo, string mensaje)
        {
            string path = @"C:\Users\NoxiePC\source\repos\Rarug.Francisco.Parcial\Archivos\archivo_txt.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha y hora: {fechaYhora}");
            sb.AppendLine($"Clase: {clase}");
            sb.AppendLine($"Metodo: {metodo}");                    
            sb.AppendLine($"Mensaje: {mensaje}");

            Archivos<string> crear = new Archivos<string>();
            crear.Escribir_TXT(path, sb.ToString());
        }
    }

    
    
}



