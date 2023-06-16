using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    public class SumarProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma para sumar.\n");
            Console.WriteLine("\nIngrese el primer número");
            float a = NumberUtilities.GetFloatInput();
            Console.WriteLine("\nIngrese el segundo número");
            float b = NumberUtilities.GetFloatInput();

            Console.WriteLine("\nSuma de " + a + " + " + b + ":");
            Console.WriteLine(Calculator.Sumar(a, b));

            Console.ReadLine();
        }
    }
}
