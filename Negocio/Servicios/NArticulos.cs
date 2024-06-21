using System;
using System.Data;
using Datos.Operaciones;
using Entidad.Clases;

namespace Negocio.Servicios
{
    public class NArticulos
    {
        public static DataTable ListarArticulos(int codNorma)
        {
            DArticulos dArticulos = new DArticulos();
            return dArticulos.ListarArticulos(codNorma);
        }

        public static  DataTable BuscarArticulos(int codNormatividad, string palabra)
        {
            DArticulos dArticulos = new DArticulos();
            return dArticulos.BuscarArticulos(codNormatividad, palabra);
        }

        public static string RegistrarArticulos(int codNormatividad, string denominacion, string descripcion, string estado, int numArticulo, int codUsuario, int pagina)
        {
            DArticulos dArticulos = new DArticulos();
            string existe = dArticulos.ExisteArticuloEnNorma(codNormatividad, numArticulo);
            Console.WriteLine($"Resultado de ExisteArticuloEnNorma: {existe}");

            if (existe.Equals("1"))
            {
                return "El articulo ya se encuentra registrado, si quiere volver a registrar" +
                    " el mismo articulo debe cambiar el estado a derogado del articulo anterior o eliminar el articulo anterior";
            }
            else
            {
                EArticulo articulo = new EArticulo();
                articulo.CodNormatividad = codNormatividad;
                articulo.Denominacion = denominacion;
                articulo.Descripcion = descripcion;
                articulo.Estado = estado;
                articulo.NumArticulo = numArticulo;
                articulo.Pagina = pagina;
                return dArticulos.RegistrarArticulos(articulo, codUsuario);

            }
        }

        public static string ActualizarArticulos(int codArticulo, int codNormatividad, string denominacion, string descripcion, string estado, int numArticulo, int pagina, int codUsuario)
        {
            DArticulos dArticulos = new DArticulos();
            return dArticulos.ActualizarArticulos(codArticulo, codNormatividad, numArticulo, denominacion, descripcion, pagina, estado, codUsuario);
        }

        public static string EliminarArticulos(int codArticulo, int codUsuario)
        {
            DArticulos dArticulos = new DArticulos();
            return dArticulos.EliminarArticulos(codArticulo, codUsuario);
        }

    }
}
