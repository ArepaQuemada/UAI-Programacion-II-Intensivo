using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dada una fecha mostrarla en el formato AAAAMMDD.

namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio13
    {
        public static void execute()
        {
            Console.Write("La fecha de hoy es: " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
