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
            string[] palabras = texto.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (!string.IsNullOrEmpty(palabras[i]))
                {
                    palabras[i] = palabras[i][0].ToString().ToUpper() + palabras[i].Substring(1).ToLower();
                }
            }

            string resultado = string.Join(" ", palabras);
            return resultado;
        }
    }
}
