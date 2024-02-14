using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dada una frase cualquiera llamada x, mostrar como resultado una fraseformada por la segunda mitad de x más la primer mitad de x. (usar elmétodo substring

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio9
    {
        public static void execute()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            int longitud = frase.Length;
            int mitad = longitud / 2;
            string segundaMitad = frase.Substring(mitad);
            string primeraMitad = frase.Substring(0, mitad);
            string resultado = segundaMitad + primeraMitad;

            Console.WriteLine("Frase resultado: " + resultado);
        }
    }
}
