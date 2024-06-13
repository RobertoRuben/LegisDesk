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
    public class NCategoriasNormas
    {
        public static DataTable ListarCategoriasNormas()
        {
            DCategoriaNorma objDCategoriaNorma = new DCategoriaNorma();
            return objDCategoriaNorma.ListarCategorias();
        }
        public static DataTable BuscarCategoriasNormas(string palabra)
        {
            DCategoriaNorma objDCategoriaNorma = new DCategoriaNorma();
            return objDCategoriaNorma.BuscarCategoria(palabra);
        }

        public static DataTable ListarUlltimosRegistro()
        {
            DCategoriaNorma objDCategoriaNorma = new DCategoriaNorma();
            return objDCategoriaNorma.ListarUltimoRegisro();
        }
        public static string RegistrarCategoriaNorma(string nombreCategoria, int codUsuario)
        {
            DCategoriaNorma dCategoriaNorma = new DCategoriaNorma();
            string existe = dCategoriaNorma.ExisteCategoria(nombreCategoria);
            Console.WriteLine($"Resultado de ExisteArticuloEnNorma: {existe}");

            if (existe.Equals("1"))
            {
                return "La categoria de norma ya existe";
            }
            else
            {
                CategoriaDeNorma categoriaDeNorma = new CategoriaDeNorma();
                categoriaDeNorma.TipoDeNorma = nombreCategoria;

                return dCategoriaNorma.RegistrarCategoria(categoriaDeNorma, codUsuario);

            }
        }

        public static string ActualizarCategoriaNorma(int codCategoria, string nombreCategoria, int codUsuario)
        {
            DCategoriaNorma dCategoriaNorma = new DCategoriaNorma();
            string existe = dCategoriaNorma.ExisteCategoria(nombreCategoria);

            if (existe.Equals("1"))
            {
                return "No puede actualizar el registro porque esa categoria de norma ya existe";
            }
            else
            {
  
                return dCategoriaNorma.ActualizarCategoria(codCategoria, nombreCategoria, codUsuario);
            }


        }

       
    }
}
