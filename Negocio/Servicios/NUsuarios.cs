using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Operaciones;

namespace Negocio.Servicios
{
    public class NUsuarios
    {
        public static DataTable Login(string usuario, string contraseña)
        {
            DUsuarios DUsuario = new DUsuarios();
            return DUsuario.Login(usuario, contraseña);
        }
    }
}
