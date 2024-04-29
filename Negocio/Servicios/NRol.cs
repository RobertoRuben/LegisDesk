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
    public class NRol
    {
        public static DataTable ListarRoles()
        {
            DRol Drol = new DRol();
            return Drol.Listar();
        }

        public static string RegistrarRoles(string nombreRol)
        {
            DRol dRol = new DRol();
            string existe = dRol.ExisteRol(nombreRol);

            if (existe.Equals("1"))
            {
                return "El nombre de usuario ya existe";
            }

            else
            {
                Rol rol = new Rol();
                rol.NombreDeRol = nombreRol;
                return dRol.RegistrarRol(rol);

            }
            
        }

        public static string ActulizarRoles(int codUsuario, int codRol, string nombreRol)
        {
            DRol dRol = new DRol();
            string existe = dRol.ExisteRol(nombreRol);

            if (existe.Equals("1"))
            {
                return "No se puede actualizar el registro porque el nombre del rol ya esta registrado";
            }
            else
            {
                return dRol.ActualzarRol(codUsuario, codRol, nombreRol);
            }

        }
    }
}
