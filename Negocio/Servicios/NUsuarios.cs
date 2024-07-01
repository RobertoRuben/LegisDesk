using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Operaciones;
using Entidad.Clases;

namespace Negocio.Servicios
{
    public class NUsuarios
    {
        public static DataTable Login(string usuario, string contraseña)
        {
            DUsuarios dUsuario = new DUsuarios();
            return dUsuario.IniciarSesion(usuario, contraseña);
        }

        public static DataTable ListarUsuario()
        {
            DUsuarios dUsuarios = new DUsuarios();
            return dUsuarios.ListarUsuarios();
        }

        public static DataTable BuscarUsuario(string palabra)
        {
            DUsuarios dUsuarios = new DUsuarios();
            return dUsuarios.BuscarUsuarios(palabra);
        }

        //Registar Usuario
        public static string RegistrarUsuario(int codTrabajador, string nombreUsuario, string contraseña, string estado, int codUsuario,int codRol)
        {
            DUsuarios dUsuarios = new DUsuarios();
            string existe = dUsuarios.VerificarUsuario(nombreUsuario);

            if (existe.Equals("1"))
            {
                return "El nombre de usuario ya existe";
            }
            else
            {
                EUsuarios usuario = new EUsuarios();

                usuario.CodTrabajador = codTrabajador;
                usuario.NombreUsuario = nombreUsuario;
                usuario.Contraseña = contraseña;
                usuario.Estado = estado;
                usuario.CodRol = codRol;

                return dUsuarios.RegistrarUsuarios(usuario, codUsuario);

            }
            
        }

        public static string ActualizarUsuario(int codUsuario, string nombreRol, string nombreUsuario, string contraseña, string estado)
        {
            DUsuarios dUsuarios = new DUsuarios();

            return dUsuarios.ActualizarUsuarios(codUsuario, nombreUsuario, contraseña, nombreRol, estado);
           
        }
        public static string ActualizarCredenciales(int codUsuario, string nombreUsuario, string contraseña)
        {
            DUsuarios dUsuarios = new DUsuarios();
            return dUsuarios.ActualizarCredenciales(codUsuario, nombreUsuario, contraseña);
        }

        public static string InhabilitarUsuario(int codUsuario, int codUsuarioSesion)
        {
            DUsuarios dUsuarios = new DUsuarios();
            EUsuarios usuario = new EUsuarios();


            return dUsuarios.InhabilitarUsuarios(codUsuario, codUsuarioSesion);
        }
    }
}
