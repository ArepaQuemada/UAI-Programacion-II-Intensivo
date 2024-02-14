using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Si la circunferencia de un círculo es pi * Diámetro, desarrollar unaaplicación que dada la circunferencia calcule el diámetro.

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio7
    {
        public static void execute()
        {
            int byteToCalculate = 0;
            int bitToBytes = 8;

            Console.WriteLine("Ingrese los Bytes");
            byteToCalculate = int.Parse(Console.ReadLine());

            Console.WriteLine("Los bits son");
            Console.WriteLine(byteToCalculate * bitToBytes);
        }
    }
}
