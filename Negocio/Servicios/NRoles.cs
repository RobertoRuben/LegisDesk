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
    public class NRoles
    {
        public static DataTable ListarRoles()
        {
            DRoles Drol = new DRoles();
            return Drol.ListarRoles();
        }

        public static DataTable BuscarRol(string palabra)
        {
            DRoles dRol = new DRoles();
            return dRol.BuscarRoles(palabra);
        }

        public static string RegistrarRoles(string nombreRol, int codUsuario)
        {
            DRoles dRol = new DRoles();
            string existe = dRol.VerificarRoles(nombreRol);

            if (existe.Equals("1"))
            {
                return "El nombre de usuario ya existe";
            }

            else
            {
                ERoles rol = new ERoles();
                rol.NombreDeRol = nombreRol;
                return dRol.RegistrarRoles(rol, codUsuario);

            }
            
        }

        public static string EliminarRol(int codRol, int codUsuario)
        {
            DRoles dRol = new DRoles();
            return dRol.EliminarRoles(codRol, codUsuario);
        }

        public static string ActulizarRoles(int codUsuario, int codRol, string nombreRol)
        {
            DRoles dRol = new DRoles();
            string existe = dRol.VerificarRoles(nombreRol);

            if (existe.Equals("1"))
            {
                return "No se puede actualizar el registro porque el nombre del rol ya esta registrado";
            }
            else
            {
                return dRol.ActualzarRoles(codUsuario, codRol, nombreRol);
            }

        }
    }
}
