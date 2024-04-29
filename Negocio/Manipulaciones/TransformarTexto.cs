using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Manipulaciones
{
    public class TransformarTexto
    {
        public static string TransformarText(string texto)
        {
            // Dividir el texto en palabras
            string[] palabras = texto.Split(' ');

            // Iterar sobre cada palabra y capitalizar la primera letra
            for (int i = 0; i < palabras.Length; i++)
            {
                // Verificar si la palabra no está vacía
                if (!string.IsNullOrEmpty(palabras[i]))
                {
                    // Convertir la primera letra a mayúscula y el resto a minúscula
                    palabras[i] = palabras[i][0].ToString().ToUpper() + palabras[i].Substring(1).ToLower();
                }
            }

            // Unir las palabras nuevamente en una cadena
            string resultado = string.Join(" ", palabras);
            return resultado;
        }
    }
}
