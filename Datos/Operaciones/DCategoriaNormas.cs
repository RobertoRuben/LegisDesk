using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conector;
using Entidad.Clases;
namespace Datos.Operaciones
{
    public class DCategoriaNormas
    {
        public DataTable ListarCategorias()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Listar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return tabla;
        }

        public DataTable BuscarCategorias(string palabra)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Buscar", sqlCon);
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

        public DataTable ListarUltimoRegistro()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Listar_UltimoRegistro", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return tabla;
        }

        public string RegistrarCategorias(ECategoriaDeNorma objCategoriaNorma, int codUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Registrar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TipoDeNorma", SqlDbType.NVarChar).Value = objCategoriaNorma.TipoDeNorma;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.NVarChar).Value = codUsuario;
               
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);
                sqlCon.Open();

                rpta = cmd.ExecuteNonQuery() >0 ? "Ok" : "No se pudo realizar el registrar";


            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;
        }

        public string EliminarCategorias(int codCategoria, int codUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Eliminar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodTipoNorma", SqlDbType.Int).Value = codCategoria;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToInt32(parametro.Value) == 1 ? "Ok" : "No se pudo eliminar la norma";
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

        public string ActualizarCategorias(int codCategoria, string tipoNorma, int codUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Actualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodCategoriaNorma", SqlDbType.Int).Value = codCategoria;
                cmd.Parameters.Add("TipoDeNorma", SqlDbType.NVarChar).Value = tipoNorma;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();

                rpta = Convert.ToInt32(parametro.Value) > 0 ? "Ok" : "No se pudo actualizar el registro";
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;
        }

        public string VerificarCategorias(string valor)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Existe", sqlCon);
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
    }
}
