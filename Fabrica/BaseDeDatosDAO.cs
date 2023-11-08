using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
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
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }
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
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }

        public static void ModificarOperario(string nuevoNombre, int id, string nuevoApellido, string nuevoPassword)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE Operario SET NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, CONTRASEÑA = @CONTRASEÑA WHERE ID = @ID";
                command.Parameters.AddWithValue("@NOMBRE", nuevoNombre);
                command.Parameters.AddWithValue("@APELLIDO", nuevoApellido);
                command.Parameters.AddWithValue("@CONTRASEÑA", nuevoPassword);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void ModificarSupervisor(string nuevoNombre, int id, string nuevoLegajo, string nuevoPassword)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE Supervisor SET NOMBRE = @NOMBRE, LEGAJO = @LEGAJO, CONTRASEÑA = @CONTRASEÑA WHERE ID = @ID";
                command.Parameters.AddWithValue("@NOMBRE", nuevoNombre);
                command.Parameters.AddWithValue("@LEGAJO", nuevoLegajo);
                command.Parameters.AddWithValue("@CONTRASEÑA", nuevoPassword);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }



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
                        operarios.Add(new Operario(reader[NOMBRE_TABLA].ToString(), reader[PASSWORD_TABLA].ToString(),Rango.Operario, reader[APELLIDO_TABLA].ToString(), Convert.ToInt32(reader[ID_TABLA])));
                    }
                }

                return operarios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
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
                        supervisores.Add(new Supervisor(reader[NOMBRE_TABLA].ToString(), reader[LEGAJO_TABLA].ToString(), Rango.Supervisor, reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader[ID_TABLA ])));
                    }
                }

                return supervisores;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarOperario(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM OPERARIO WHERE ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void EliminarSupervisor(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM SUPERVISOR WHERE ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
