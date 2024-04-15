using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Operaciones;

namespace Negocio.Servicios
{
    public class NCategoriasNormas
    {
        public static DataTable ListarNormas()
        {
            DCategoriaNorma objDCategoriaNorma = new DCategoriaNorma();
            return objDCategoriaNorma.ListarCategorias();
        }

        public static DataTable ListarUlltimosRegistro()
        {
            DCategoriaNorma objDCategoriaNorma = new DCategoriaNorma();
            return objDCategoriaNorma.ListarUltimoRegisro();
        }

       
    }
}
