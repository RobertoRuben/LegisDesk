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
        public DataTable ListarNormas()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Trabajadores_Listar", sqlCon);
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

        public string RegistrarTrabajadores(Trabajador objTrabajador)
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

        public string ActualizarTrabajadores(int codTrabajador, int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string sexo)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("SP_TrabajoresActualizar", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodTrabajador", SqlDbType.Int).Value = codTrabajador;
                cmd.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
                cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.NVarChar).Value = apellidoPaterno;
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.NVarChar).Value = apellidoMaterno;
                cmd.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = sexo;
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
