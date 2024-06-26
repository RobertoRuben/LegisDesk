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
    public class DNormas
    {
        public DataTable ListarNormas()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Normas_Listar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return tabla;

        }
        public DataTable BuscarNormas(string palabra)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Normas_Buscar", sqlCon);
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

        public string RegistrarNormas(ENormas objNormas)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Normas_Registrar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodUsuario", SqlDbType.Int).Value = objNormas.CodUsuario;
                cmd.Parameters.Add("@CodTipoNorma", SqlDbType.Int).Value = objNormas.CodTipoNorma;
                cmd.Parameters.Add("@NumeroNorma", SqlDbType.NVarChar).Value = objNormas.NumeroNorma;
                cmd.Parameters.Add("@NombreNorma", SqlDbType.NVarChar).Value = objNormas.NombreNorma;
                cmd.Parameters.Add("@Resumen", SqlDbType.NVarChar).Value = objNormas.Resumen;
                cmd.Parameters.Add("@FechaPublicacion", SqlDbType.NVarChar).Value = objNormas.FechaPublicacion;
                cmd.Parameters.Add("@CantidadDePaginas", SqlDbType.Int).Value = objNormas.CantidadDePaginas;
                cmd.Parameters.Add("@MedioPublicacion", SqlDbType.NVarChar).Value = objNormas.MedioPublicacion;
                cmd.Parameters.Add("@LinkDocumentos", SqlDbType.NVarChar).Value = objNormas.LinkDocumento;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = objNormas.Estado;

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Rpta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                sqlCon.Open();
                cmd.ExecuteNonQuery();

                rpta = Convert.ToInt32(parametro.Value) > 0 ? "Ok" : "No se pudo insertar el registro";

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

        public string ActualizarNormas(int codNormatividad, int codTipoNorma, string numeroNorma, string nombreNorma, string resumen, string fechaPublicacion,
            int cantidadPaginas, string medioPublicacion, string linkDocumento, string estado, int codUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Normas_Actualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodNormatividad", SqlDbType.Int).Value = codNormatividad;
                cmd.Parameters.Add("@CodTipoNorma", SqlDbType.Int).Value = codTipoNorma;
                cmd.Parameters.Add("@NumeroNorma", SqlDbType.NVarChar).Value  = numeroNorma;
                cmd.Parameters.Add("@NombreNorma", SqlDbType.NVarChar).Value = nombreNorma;
                cmd.Parameters.Add("@Resumen", SqlDbType.NVarChar).Value = resumen;
                cmd.Parameters.Add("@FechaPublicacion", SqlDbType.NVarChar).Value = fechaPublicacion;
                cmd.Parameters.Add("@CantidadPaginas", SqlDbType.Int).Value = cantidadPaginas;
                cmd.Parameters.Add("@MedioPublicacion", SqlDbType.NVarChar).Value = medioPublicacion;
                cmd.Parameters.Add("@LinkDocumento", SqlDbType.NVarChar).Value = linkDocumento;
                cmd.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = estado;
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
        public string EliminarNormas(int codNormatividad, int codUsuario)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Normas_Eliminar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodNormatividad", SqlDbType.Int).Value = codNormatividad;
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
        public string ExisteNumeroNorma(string valor)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Normas_VerificarNumero", sqlCon);
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

