using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conector;
using Entidad.Clases;
namespace Datos.Operaciones
{
    public class DCategoriaNorma
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

        public DataTable BuscarCategoria(string palabra)
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

        public DataTable ListarUltimoRegisro()
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

        public string RegistrarCategoria(CategoriaDeNorma objCategoriaNorma, int codUsuario)
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

        public string ActualizarCategoria(int codCategoria, string tipoNorma, int codUsuario)
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

                // Leer el parámetro de salida después de ejecutar el procedimiento
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
        public string DesactivarCategoria(CategoriaDeNorma categoriaDeNorma)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Desactivar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "Se desactivo la norma" : "No se puedo inhabilitar la norma";
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
        public string ExisteCategoria(string valor)
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
