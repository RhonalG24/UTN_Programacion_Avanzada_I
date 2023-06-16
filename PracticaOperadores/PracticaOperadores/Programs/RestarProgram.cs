using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class RestarProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma para restar.\n");
            Console.WriteLine("\nIngrese el primer número");
            float a = NumberUtilities.GetFloatInput();
            Console.WriteLine("\nIngrese el segundo número");
            float b = NumberUtilities.GetFloatInput();

            Console.WriteLine("\nResta de " + a + " - " + b + ":");
            Console.WriteLine(Calculator.Restar(a, b));

            Console.ReadLine();
        }
    }
}
