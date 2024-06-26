using System.Data;
using Datos.Operaciones;
using Entidad.Clases;

namespace Negocio.Servicios
{
    public class NNormas
    {
       public static DataTable ListarNormas()
        {
            DNormas dNormas = new DNormas();
            return dNormas.ListarNormas();
        }

        public static DataTable BuscarNormas(string palabra)
        {
            DNormas dNormas = new DNormas();
            return dNormas.BuscarNormas(palabra);
        }

        public static string RegistrarNormas(int codUsuario, int codTipoNorma, string numeroNorma, string nombreNorma, string resumen,string fechaPublicacion, int cantidadPaginas,
            string medioPublicacion, string linkDocumentos, string estado)
        {
            DNormas dNormas = new DNormas();
            string existe = dNormas.ExisteNumeroNorma(numeroNorma);

            if (existe.Equals("1"))
            {
                return "El numero de norma ya se encuentra registrada, para registrar la misma norma, eliminela";
            }
            else
            {
                ENormas normas = new ENormas();

                normas.CodUsuario = codUsuario;
                normas.CodTipoNorma = codTipoNorma;
                normas.NumeroNorma = numeroNorma;
                normas.NombreNorma = nombreNorma;
                normas.Resumen = resumen;
                normas.FechaPublicacion = fechaPublicacion;
                normas.CantidadDePaginas = cantidadPaginas;
                normas.MedioPublicacion = medioPublicacion;
                normas.LinkDocumento = linkDocumentos;
                normas.Estado = estado;

                return dNormas.RegistrarNormas(normas);

            }
        }

        public static string ActualizarNormas(int codNormatividad, int codTipoNorma, string numeroNorma, string nombreNorma, string resumen, string fechaPublicacion, int cantidadPaginas,
            string medioPublicacion, string linkDocumentos, string estado, int codUsuario)
        {
            DNormas dNormas = new DNormas();

            return dNormas.ActualizarNormas(codNormatividad, codTipoNorma, numeroNorma, nombreNorma, resumen, fechaPublicacion, cantidadPaginas, medioPublicacion, linkDocumentos, estado, codUsuario);
            
        }

        public static string EliminarNormas(int codNormatividad, int codUsuario)
        {
            DNormas dNormas = new DNormas();
            return dNormas.EliminarNormas(codNormatividad, codUsuario);
        }
    }
}
