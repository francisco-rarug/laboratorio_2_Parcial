using System.Text.Json;
using System.Text;
using System.Xml.Serialization;

namespace Fabrica
{
    /// <summary>
    /// Clase genérica para trabajar con archivos.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto que se va a manejar en los archivos.</typeparam>
    public class Archivos<T> : Iarchivos<T>
    {
        /// <summary>
        /// Escribe datos en un archivo de texto.
        /// </summary>
        /// <param name="path">Ruta del archivo.</param>
        /// <param name="datos">Datos a escribir en el archivo.</param>
        /// <returns>True si la operación fue exitosa, false si hubo un error.</returns>
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

        /// <summary>
        /// Escribe un objeto en formato JSON en un archivo.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <param name="objeto">Objeto a serializar y escribir.</param>
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

        /// <summary>
        /// Lee un archivo JSON y deserializa el contenido a un objeto.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto esperado.</typeparam>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <returns>Objeto deserializado.</returns>
        public T Leer_JSON<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            T objeto = JsonSerializer.Deserialize<T>(jsonString);
            return objeto;
        }

        /// <summary>
        /// Escribe un objeto en formato XML en un archivo.
        /// </summary>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <param name="objeto">Objeto a serializar y escribir.</param>
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

        /// <summary>
        /// Lee un archivo XML y deserializa el contenido a un objeto.
        /// </summary>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <returns>Objeto deserializado.</returns>
        public T LeerXml(string path)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(sw);
            }
        }

        /// <summary>
        /// Registra errores en un archivo de texto.
        /// </summary>
        /// <param name="fechaYhora">Fecha y hora del error.</param>
        /// <param name="clase">Nombre de la clase donde ocurrió el error.</param>
        /// <param name="metodo">Nombre del método donde ocurrió el error.</param>
        /// <param name="mensaje">Descripción del error.</param>
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




