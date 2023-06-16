using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class MultiplicarProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma para multiplicar.\n");
            Console.WriteLine("\nIngrese el primer número");
            float a = NumberUtilities.GetFloatInput();
            Console.WriteLine("\nIngrese el segundo número");
            float b = NumberUtilities.GetFloatInput();

            Console.WriteLine("\nMultiplicación de " + a + " * " + b + ":");
            Console.WriteLine(Calculator.Multiplicar(a, b));

            Console.ReadLine();
        }
    }
}
