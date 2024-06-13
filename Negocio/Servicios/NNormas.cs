using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return dNormas.BuscarNorma(palabra);
        }

        public static string RegistrarNormas(int codUsuario, int codTipoNorma, string numeroNorma, string nombreNorma, string resumen,string fechaPublicacion, int cantidadPaginas,
            string medioPublicacion, string linkDocumentos, string estado)
        {
            DNormas dNormas = new DNormas();
            string existe = dNormas.ExisteNumeroNorma(numeroNorma);

            if (existe.Equals("1"))
            {
                return "El numero de norma ya se encuentra registrada";
            }
            else
            {
                Normas normas = new Normas();

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
            string medioPublicacion, string linkDocumentos, string estado)
        {
            DNormas dNormas = new DNormas();
            string existe = dNormas.ExisteNumeroNorma(numeroNorma);

            return dNormas.ActualizarNormas(codNormatividad, codTipoNorma, numeroNorma, nombreNorma, resumen, fechaPublicacion, cantidadPaginas, medioPublicacion, linkDocumentos, estado);
            
        }

        public static string EliminarNormas(int codNormatividad)
        {
            DNormas dNormas = new DNormas();
            return dNormas.EliminarNormas(codNormatividad);
        }
    }
}
