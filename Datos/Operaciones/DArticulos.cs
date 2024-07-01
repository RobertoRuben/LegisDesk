using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
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
        public DataTable ListarUltimoRegistro()
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

        public string RegistrarArticulos(EArticulo objArticulo, int codUsuario)
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
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;
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


        public string ActualizarArticulos(int codArticulo, int codNormatividad, int numArticulo, string denominacion, string descripcion, int pagina, string estado, int codUsuario)
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
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;

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

        public string EliminarArticulos(int codArticulo, int codUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Articulos_Eliminar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodArticulo", SqlDbType.Int).Value = codArticulo;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = codUsuario;

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

        public string VerificarArticuloEnNorma(int codNormatividad, int numArticulo)
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
