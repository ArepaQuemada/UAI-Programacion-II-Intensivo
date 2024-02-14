using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dadas dos fechas calcular la diferencia en días entre una y la otra.

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio14
    {
        public static void execute()
        {
            Console.Write("Ingrese dos fechas (AAAA-MM-DD): ");
            
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());
            int diferencia = (int)(fecha2 - fecha1).TotalDays;

            Console.WriteLine("La diferenmncia es" + diferencia);
        }
    }
}
