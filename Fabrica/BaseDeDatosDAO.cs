using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Clase que proporciona métodos para interactuar con la base de datos.
    /// </summary>
    public class BaseDeDatosDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string NOMBRE_TABLA = "NOMBRE";
        const string APELLIDO_TABLA = "APELLIDO";
        const string PASSWORD_TABLA = "CONTRASEÑA";
        const string LEGAJO_TABLA = "LEGAJO";
        const string ID_TABLA = "ID";

        static BaseDeDatosDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=MISTICAMOUSSE;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Guarda un operario en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del operario.</param>
        /// <param name="apellido">Apellido del operario.</param>
        /// <param name="password">Contraseña del operario.</param>
        /// <param name="rango">Rango del operario.</param>
        public static void GuardarOperario(string nombre, string apellido, string password, string rango)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO OPERARIO (NOMBRE,APELLIDO,RANGO,CONTRASEÑA) VALUES (@NOMBRE,@APELLIDO,@RANGO,@CONTRASEÑA)";
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@APELLIDO", apellido);
                command.Parameters.AddWithValue("@RANGO", rango);
                command.Parameters.AddWithValue("@CONTRASEÑA", password);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally { connection.Close(); }
        }

        /// <summary>
        /// Guarda un supervisor en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del supervisor.</param>
        /// <param name="password">Contraseña del supervisor.</param>
        /// <param name="legajo">Legajo del supervisor.</param>
        /// <param name="rango">Rango del supervisor.</param>
        public static void GuardarSupervisor(string nombre, string password, string legajo, string rango)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO SUPERVISOR (NOMBRE,CONTRASEÑA,RANGO,LEGAJO) VALUES (@NOMBRE,@CONTRASEÑA,@RANGO,@LEGAJO)";
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@CONTRASEÑA", password);
                command.Parameters.AddWithValue("@RANGO", rango);
                command.Parameters.AddWithValue("@LEGAJO", legajo);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally { connection.Close(); }
        }

        /// <summary>
        /// Modifica los datos de un operario en la base de datos.
        /// </summary>
        /// <param name="nuevoNombre">Nuevo nombre del operario.</param>
        /// <param name="id">ID del operario a modificar.</param>
        /// <param name="nuevoApellido">Nuevo apellido del operario.</param>
        /// <param name="nuevoPassword">Nueva contraseña del operario.</param>
        public static void ModificarOperario(string nuevoNombre, int id, string nuevoApellido, string nuevoPassword)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE OPERARIO SET NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, CONTRASEÑA = @CONTRASEÑA WHERE ID = @ID";
                command.Parameters.AddWithValue("@NOMBRE", nuevoNombre);
                command.Parameters.AddWithValue("@APELLIDO", nuevoApellido);
                command.Parameters.AddWithValue("@CONTRASEÑA", nuevoPassword);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Modifica los datos de un supervisor en la base de datos.
        /// </summary>
        /// <param name="nuevoNombre">Nuevo nombre del supervisor.</param>
        /// <param name="id">ID del supervisor a modificar.</param>
        /// <param name="nuevoLegajo">Nuevo legajo del supervisor.</param>
        /// <param name="nuevoPassword">Nueva contraseña del supervisor.</param>
        public static void ModificarSupervisor(string nuevoNombre, int id, string nuevoLegajo, string nuevoPassword)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE SUPERVISOR SET NOMBRE = @NOMBRE, LEGAJO = @LEGAJO, CONTRASEÑA = @CONTRASEÑA WHERE ID = @ID";
                command.Parameters.AddWithValue("@NOMBRE", nuevoNombre);
                command.Parameters.AddWithValue("@LEGAJO", nuevoLegajo);
                command.Parameters.AddWithValue("@CONTRASEÑA", nuevoPassword);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Lee la lista de operarios desde la base de datos.
        /// </summary>
        /// <returns>Lista de operarios.</returns>
        public static List<Operario> LeerOperarios()
        {
            List<Operario> operarios = new List<Operario>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM OPERARIO";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        operarios.Add(new Operario(reader[NOMBRE_TABLA].ToString(), reader[PASSWORD_TABLA].ToString(), Rango.Operario, reader[APELLIDO_TABLA].ToString(), Convert.ToInt32(reader[ID_TABLA])));
                    }
                }

                return operarios;
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Lee la lista de supervisores desde la base de datos.
        /// </summary>
        /// <returns>Lista de supervisores.</returns>
        public static List<Supervisor> LeerSupervisor()
        {
            List<Supervisor> supervisores = new List<Supervisor>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM SUPERVISOR ";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        supervisores.Add(new Supervisor(reader[NOMBRE_TABLA].ToString(), reader[PASSWORD_TABLA].ToString(), Rango.Supervisor, reader[LEGAJO_TABLA].ToString(), Convert.ToInt32(reader[ID_TABLA])));
                    }
                }

                return supervisores;
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Elimina un operario de la base de datos.
        /// </summary>
        /// <param name="id">ID del operario a eliminar.</param>
        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM OPERARIO WHERE ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Elimina un operario o supervisor de la base de datos.
        /// </summary>
        /// <param name="id">ID del operario o supervisor a eliminar.</param>
        /// <param name="labor">Tipo de trabajo (operario o supervisor).</param>
        public static void Eliminar(int id, string labor)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM {labor} WHERE ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
