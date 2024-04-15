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
                cmd.Parameters.Add("@Contrasena", SqlDbType.NVarChar).Value = contraseña;
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
                cmd.Parameters.Add("@Contrasena", SqlDbType.NVarChar).Value = objUsuario.Contraseña;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = objUsuario.Estado;
                cmd.Parameters.Add("@CodRol", SqlDbType.Int).Value = objUsuario.CodRol;
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
                SqlCommand cmd = new SqlCommand("Sp_UsuarioActualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario");
                cmd.Parameters.Add("@CodTrabajador", SqlDbType.Int).Value = objUsuario.CodTrabajador;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = objUsuario.NombreUsuario;
                cmd.Parameters.Add("@Contrasena", SqlDbType.NVarChar).Value = objUsuario.Contraseña;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = objUsuario.Estado;
                cmd.Parameters.Add("@CodRol", SqlDbType.Int).Value = objUsuario.CodRol;

                sqlCon.Open();

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar el registro";

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

        public string InhabilitarUsuario(Usuario objUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_UsuarioInhabilitar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = objUsuario.CodUsuario;

                sqlCon.Open();

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo inhabilitar al trabajador";
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
