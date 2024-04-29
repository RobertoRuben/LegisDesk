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

        public string RegistrarNormas(Normas objNormas)
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

                // Leer el parámetro de salida después de ejecutar el procedimiento
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

        public string Actualizar(Trabajador objTrabajador)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("SP_TrabajoresActualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodTrabajador", SqlDbType.Int).Value = objTrabajador.CodTrabajador;
                cmd.Parameters.Add("@Dni", SqlDbType.Int).Value = objTrabajador.Dni;
                cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = objTrabajador.Nombre;
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.NVarChar).Value = objTrabajador.ApellidoPaterno;
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.NVarChar).Value = objTrabajador.ApellidoMaterno;
                cmd.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = objTrabajador.Sexo;
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo Actualizar el Registro";
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

