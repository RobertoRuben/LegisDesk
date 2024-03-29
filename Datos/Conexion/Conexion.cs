using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.Conexion
{
    public class Conexion
    {
        private string dataBase;
        private string servidor;
        private string usuario;
        private string contraseña;
        private bool seguridad;

        private static Conexion Con = null;

        private Conexion()
        {
            this.dataBase = "SistemaDeNormatividad";
            this.servidor = "localhost";
            this.usuario = "sa";
            this.contraseña = "oracle";
            this.seguridad = true;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.servidor + "; Database=" + this.dataBase + ";";
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.usuario + ";Password=" + this.contraseña;
                }
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex; 

            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }

}
