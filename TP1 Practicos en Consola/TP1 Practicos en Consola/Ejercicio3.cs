using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Datos los lados de un triangulo calcular el perimetro 
namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio3
    {
        public static void execute()
        {
            int ladoA = 0;
            int ladoB = 0;
            int ladoC = 0;

            Console.WriteLine("Ingrese 3 lados del triangulo");
            ladoA = int.Parse(Console.ReadLine());
            ladoB = int.Parse(Console.ReadLine());
            ladoC = int.Parse(Console.ReadLine());

            Console.WriteLine("El perimetro es");
            Console.WriteLine(ladoA + ladoB + ladoC);
        }
    }
}
