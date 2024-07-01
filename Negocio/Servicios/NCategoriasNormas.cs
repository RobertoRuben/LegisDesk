using Datos.Operaciones;
using Entidad.Clases;
using System.Data;

namespace Negocio.Servicios
{
    public class NCategoriasNormas
    {
        public static DataTable ListarCategoriasNormas()
        {
            DCategoriaNormas objDCategoriaNorma = new DCategoriaNormas();
            return objDCategoriaNorma.ListarCategorias();
        }
        public static DataTable BuscarCategoriasNormas(string palabra)
        {
            DCategoriaNormas objDCategoriaNorma = new DCategoriaNormas();
            return objDCategoriaNorma.BuscarCategorias(palabra);
        }

        public static DataTable ListarUlltimosRegistro()
        {
            DCategoriaNormas objDCategoriaNorma = new DCategoriaNormas();
            return objDCategoriaNorma.ListarUltimoRegistro();
        }
        public static string RegistrarCategoriaNormas(string nombreCategoria, int codUsuario)
        {
            DCategoriaNormas dCategoriaNorma = new DCategoriaNormas();
            string existe = dCategoriaNorma.VerificarCategorias(nombreCategoria);

            if (existe.Equals("1"))
            {
                return "La categoria de norma ya existe";
            }
            else
            {
                ECategoriaDeNorma categoriaDeNorma = new ECategoriaDeNorma();
                categoriaDeNorma.TipoDeNorma = nombreCategoria;

                return dCategoriaNorma.RegistrarCategorias(categoriaDeNorma, codUsuario);

            }
        }

        public static string ActualizarCategoriaNormas(int codCategoria, string nombreCategoria, int codUsuario)
        {
            DCategoriaNormas dCategoriaNorma = new DCategoriaNormas();
            string existe = dCategoriaNorma.VerificarCategorias(nombreCategoria);

            if (existe.Equals("1"))
            {
                return "No puede actualizar el registro porque esa categoria de norma ya existe";
            }
            else
            {
  
                return dCategoriaNorma.ActualizarCategorias(codCategoria, nombreCategoria, codUsuario);
            }
        }

        public static string EliminarCategoriaNormas(int codCategoria, int codUsuario)
        {
            DCategoriaNormas dCategoriaNorma = new DCategoriaNormas();
            return dCategoriaNorma.EliminarCategorias(codCategoria, codUsuario);
        }
       
    }
}
