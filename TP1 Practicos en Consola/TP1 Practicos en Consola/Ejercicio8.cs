using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio8
    {
        public static void execute()
        {
            int numToFactorial = 6;

            Console.WriteLine("El factorial de 6 es");
            Console.WriteLine(factorial(numToFactorial));
        }

        static int factorial(int num)
        {
            if (num == 1)
            {
                return num;
            }
            else
            {
                 return num * factorial(num - 1);
            }
        }
    }
}
