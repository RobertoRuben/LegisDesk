using System;
using System.Data;
using System.Data.SqlClient;
using Entidad.Clases;
using Datos.Conector;

namespace Datos.Operaciones
{
    public class DUsuarios
    {
        public DataTable ListarUsuarios()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Listar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return tabla;
        }

        public DataTable BuscarUsuarios(string palabra)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Buscar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Palabra", SqlDbType.NVarChar).Value = palabra;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return tabla;
        }

        public DataTable IniciarSesion(string usuario, string contraseña)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Login", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = usuario;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = contraseña;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return tabla;
        }

        public string RegistrarUsuarios(EUsuarios objUsuario, int codUsuario) 
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Registrar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodTrabajador", SqlDbType.Int).Value = objUsuario.CodTrabajador;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = objUsuario.NombreUsuario;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = objUsuario.Contraseña;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = objUsuario.Estado;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;
                cmd.Parameters.Add("@CodRol", SqlDbType.Int).Value = objUsuario.CodRol;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToInt32(parametro.Value) == 1 ? "Ok" : "No se pudo insertar el registro";

                Console.WriteLine("RptaProcdimiento: " + rpta);
            }
            catch(Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;
        }

        public string ActualizarUsuarios(int codUsuario, string nombre, string contraseña, string nombreRol, string estado)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Actualizar_v2", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = contraseña;
                cmd.Parameters.Add("@NombreRol", SqlDbType.NVarChar).Value = nombreRol;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = estado;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToInt32(parametro.Value) == 1 ? "Ok" : "No se pudo actualizar el registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;
        }
        public string ActualizarCredenciales(int codUsuario, string nombre, string contraseña)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_ActualizarCredenciales", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = contraseña;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToInt32(parametro.Value) == 1 ? "Ok" : "No se pudo actualizar el registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;
        }

        public string InhabilitarUsuarios(int codUsuario, int codUsuarioSesion)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Inhabilitar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;
                cmd.Parameters.Add("@CodUsuarioSesion", SqlDbType.Int).Value = codUsuarioSesion;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery()> 0 ? "Ok" : "No se pudo inhabilitar al trabajador";
            }
            catch(Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;
        }

        public string ExisteUsuario(string valor)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Verificar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Valor", SqlDbType.NVarChar).Value = valor;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);
                sqlCon.Open();

                cmd.ExecuteNonQuery();
                rpta = Convert.ToString(parametro.Value);

            }
            catch(Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;

        }
    }

}
