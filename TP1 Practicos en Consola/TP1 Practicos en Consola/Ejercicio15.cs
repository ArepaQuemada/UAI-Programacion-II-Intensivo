using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// Informar cuantos días faltan para el 25/12/2024.

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio15
    {
        public static void execute()
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaExpected = new DateTime(2024, 12, 25);

            int diasDifference = (int)(fechaActual - fechaExpected).TotalDays;
            Console.Write("Faltan dias " + diasDifference);
        }
    }
}
