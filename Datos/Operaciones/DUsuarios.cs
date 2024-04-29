using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DataTable Login(string usuario, string contraseña)
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

        public string RegistrarUsuarios(Usuario objUsuario) 
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
                cmd.Parameters.Add("@CodRol", SqlDbType.Int).Value = objUsuario.CodRol;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo insertar el registro";
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

        public string ActualizarUsuario(Usuario objUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Actualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = objUsuario.CodUsuario;
                cmd.Parameters.Add("@CodTrabajador", SqlDbType.Int).Value = objUsuario.CodTrabajador;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = objUsuario.NombreUsuario;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = objUsuario.Contraseña;
                cmd.Parameters.Add("@CodRol", SqlDbType.Int).Value = objUsuario.CodRol;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = objUsuario.Estado;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo insertar el registro";

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

        public string InhabilitarUsuario(int codUsuario, int codUsuarioSesion)
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

        public string Existe(string valor)
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
