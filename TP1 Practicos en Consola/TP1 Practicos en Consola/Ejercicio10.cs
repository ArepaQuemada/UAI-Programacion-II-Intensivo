using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dadas dos frases concatenarlas y mostrar el resultado.

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio10
    {
        public static void execute()
        {
            Console.Write("Ingrese dos una frases: ");
            string frase1 = Console.ReadLine();
            string frase2 = Console.ReadLine();

            Console.WriteLine("Frase resultado: " + frase1 + frase2);
        }
    }
}
