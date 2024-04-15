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
    public class DTrabajadores
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("SP_ListarTrabajadores", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return tabla;

        }

        public string Registrar(Trabajador objTrabajador)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("SP_TrabajadoresRegistrar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Dni", SqlDbType.Int).Value = objTrabajador.Dni;
                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = objTrabajador.Nombre;
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.NVarChar).Value = objTrabajador.ApellidoPaterno;
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.NVarChar).Value = objTrabajador.ApellidoMaterno;
                cmd.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = objTrabajador.Sexo;
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery()==1?"Ok":"No se pudo insertar el registro";
               
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
