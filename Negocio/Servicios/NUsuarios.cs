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
            return dUsuario.Login(usuario, contraseña);
        }

        public static DataTable ListarUsuario()
        {
            DUsuarios dUsuarios = new DUsuarios();
            return dUsuarios.ListarUsuarios();
        }

        //Registar Usuario
        public static string RegistrarUsuario(int codTrabajador, string nombreUsuario, string contraseña, string estado, int codRol)
        {
            DUsuarios dUsuarios = new DUsuarios();
            string existe = dUsuarios.Existe(nombreUsuario);

            if (existe.Equals("1"))
            {
                return "El nombre de usuario ya existe";
            }
            else
            {
                Usuario usuario = new Usuario();

                usuario.CodTrabajador = codTrabajador;
                usuario.NombreUsuario = nombreUsuario;
                usuario.Contraseña = contraseña;
                usuario.Estado = estado;
                usuario.CodRol = codRol;

                return dUsuarios.RegistrarUsuarios(usuario);

            }
            
        }

        public static string ActualizarUsuario(int codUsuario, int codTrabajador, int codRol, string nombreUsuario, string contraseña, string estado)
        {
            DUsuarios dUsuarios = new DUsuarios();
            Usuario usuario = new Usuario();

            usuario.CodUsuario = codUsuario;
            usuario.CodTrabajador = codTrabajador;
            usuario.CodRol = codRol;
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contraseña = contraseña;
            usuario.Estado = estado;

            return dUsuarios.ActualizarUsuario(usuario);
           
        }

        public static string InhabilitarUsuario(int codUsuario, int codUsuarioSesion)
        {
            DUsuarios dUsuarios = new DUsuarios();
            Usuario usuario = new Usuario();


            return dUsuarios.InhabilitarUsuario(codUsuario, codUsuarioSesion);
        }
    }
}
