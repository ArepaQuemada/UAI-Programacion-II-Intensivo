using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dados los datos necesarios de un Rectángulo calcular la superficie.
namespace TP1_Practicos_en_Consola
{
    internal class Ejercicio5
    {
        public static void execute()
        {
            int largo = 0;
            int ancho = 0;

            Console.WriteLine("Ingrese el largo y ancho del rectangulo");
            largo = int.Parse(Console.ReadLine());
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("La superficie es");
            Console.WriteLine(largo * ancho);
        }
    }
}
