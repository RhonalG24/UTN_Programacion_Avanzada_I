using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class RestoProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma para calcular el resto de una división.\n");
            Console.WriteLine("\nIngrese el primer número");
            float a = NumberUtilities.GetFloatInput();
            Console.WriteLine("\nIngrese el segundo número");
            float b = NumberUtilities.GetFloatInput();
            try
            {
                Console.WriteLine("\nResto de " + a + " / " + b + ":");
                Console.WriteLine(Calculator.Resto(a, b));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
