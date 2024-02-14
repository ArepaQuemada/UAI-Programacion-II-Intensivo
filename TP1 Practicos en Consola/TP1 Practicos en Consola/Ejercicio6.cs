using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio6
    {
        public static void execute()
        {
            float diametro = 0;

            Console.WriteLine("Ingrese el valor de la circunferencia");
            diametro = float.Parse(Console.ReadLine());

            Console.WriteLine("El diametro es");
            Console.WriteLine(diametro / Math.PI);
        }
    }
}
