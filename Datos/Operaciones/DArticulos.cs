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
    public class DArticulos
    {
        public DataTable ListarArticulos(int codNorma)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Listar", sqlCon);
                cmd.Parameters.Add("@CodNorma", SqlDbType.Int).Value = codNorma;

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
        public DataTable ListarUltimoRegisro()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Listar_UltimoRegistro", sqlCon);
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

        public DataTable BuscarArticulos(int codNormatividad, string palabra)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Buscar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                cmd.Parameters.Add("@CodNormatividad", SqlDbType.Int).Value = codNormatividad;
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

        public string RegistrarArticulo(Articulo objArticulo)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Registrar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodNormatividad", SqlDbType.Int).Value = objArticulo.CodNormatividad;
                cmd.Parameters.Add("@NumArticulo", SqlDbType.Int).Value = objArticulo.NumArticulo;
                cmd.Parameters.Add("@Denominacion", SqlDbType.NVarChar).Value = objArticulo.Denominacion;
                cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = objArticulo.Descripcion;
                cmd.Parameters.Add("@Pagina", SqlDbType.Int).Value = objArticulo.Pagina;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = objArticulo.Estado;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToInt32(parametro.Value) == 1 ? "Ok" : "No se pudo insertar el registro";
            }
            catch (Exception e)
            {
                // Capturar detalles adicionales de la excepción
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(e.Message);
                sb.AppendLine(e.StackTrace);

                if (e.InnerException != null)
                {
                    sb.AppendLine("Inner Exception:");
                    sb.AppendLine(e.InnerException.Message);
                    sb.AppendLine(e.InnerException.StackTrace);
                }

                rpta = sb.ToString();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rpta;
        }


        public string ActualizarArticulo(int codArticulo, int codNormatividad, int numArticulo, string denominacion, string descripcion, int pagina, string estado)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Actualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodArticulo", SqlDbType.Int).Value = codArticulo;
                cmd.Parameters.Add("@CodNormatividad", SqlDbType.Int).Value = codNormatividad;
                cmd.Parameters.Add("@NumArticulo", SqlDbType.Int).Value = numArticulo;
                cmd.Parameters.Add("@Denominacion", SqlDbType.NVarChar).Value = denominacion;
                cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = descripcion;
                cmd.Parameters.Add("@Pagina", SqlDbType.Int).Value = pagina;
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

        public string EliminarArticulo(int codArticulo)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Eliminar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodArticulo", SqlDbType.Int).Value = codArticulo;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToInt32(parametro.Value) == 1 ? "Ok" : "No se pudo eliminar el registro";
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

        public string ExisteArticuloEnNorma(int codNormatividad, int numArticulo)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulo_ExisteEnNorma", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodNormatividad", SqlDbType.Int).Value = codNormatividad;
                cmd.Parameters.Add("@NumArticulo", SqlDbType.Int).Value = numArticulo;

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
