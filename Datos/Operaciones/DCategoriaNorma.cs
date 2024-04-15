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

        public DataTable ListarUltimoRegisro()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_ListarUltimoRegistro", sqlCon);
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

        public string RegistrarCategoria(CategoriaDeNorma objCategoriaNorma)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Registrar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TipoDeNorma", SqlDbType.NVarChar).Value = objCategoriaNorma.TipoDeNorma;
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "Registro Exitoso" : "No se pudo realizar el registrar";


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

        public string ActualizarCategoria(CategoriaDeNorma objCategoriaNorma)
        {
            string rpta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Sp_CategoriaNorma_Actualizar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CodTipoNorma", SqlDbType.Int).Value = objCategoriaNorma.CodTipoNorma;
                cmd.Parameters.Add("TipoDeNorma", SqlDbType.NVarChar).Value = objCategoriaNorma.TipoDeNorma;
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "Actualizacion Exitosa" : "No se pudo Actualizar el Registro";
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
    }
}
