using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dada una frase informar la cantidad de caracteres que tiene.

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio11
    {
        public static void execute()
        {
            Console.Write("Ingrese una una frases: ");
            string frase = Console.ReadLine();

            Console.WriteLine("resultado: " + frase.Length);
        }
    }
}
