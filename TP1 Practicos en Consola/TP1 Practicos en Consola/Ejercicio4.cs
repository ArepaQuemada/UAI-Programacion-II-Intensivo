using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dados los datos necesarios de un Cuadrado calcular la superficie.
namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio4
    {
        public static void execute()
        {
            int longitud = 0;

            Console.WriteLine("Ingrese la longitud del cuadrado");
            longitud = int.Parse(Console.ReadLine());

            Console.WriteLine("La superficie es");
            Console.WriteLine(Math.Pow(longitud, 2));
        }
    }
}
