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

        public static string RegistrarArticulos(int codNormatividad, string denominacion, string descripcion, string estado, int numArticulo, int pagina)
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
                Articulo articulo = new Articulo();
                articulo.CodNormatividad = codNormatividad;
                articulo.Denominacion = denominacion;
                articulo.Descripcion = descripcion;
                articulo.Estado = estado;
                articulo.NumArticulo = numArticulo;
                articulo.Pagina = pagina;
                return dArticulos.RegistrarArticulo(articulo);

            }
        }

        public static string ActualizarArticulo(int codArticulo, int codNormatividad, string denominacion, string descripcion, string estado, int numArticulo, int pagina)
        {
            DArticulos dArticulos = new DArticulos();
            return dArticulos.ActualizarArticulo(codArticulo, codNormatividad, numArticulo, denominacion, descripcion, pagina, estado);
        }

        public static string EliminarArticulo(int codArticulo)
        {
            DArticulos dArticulos = new DArticulos();
            return dArticulos.EliminarArticulo(codArticulo);
        }

    }
}
