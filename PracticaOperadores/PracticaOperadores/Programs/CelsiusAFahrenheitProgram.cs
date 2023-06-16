using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class CelsiusAFahrenheitProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma de conversión de grados Celsius a grados Fahrenheit.");
            Console.WriteLine("\nIngrese la temperatura en grados Celsius: ");
            float input1 = NumberUtilities.GetIntInput();
            Console.WriteLine("\n" + input1 + "° Celsius es equivalente a " + Calculator.CelsiusAFahrenheit(input1) + "° Fahrenheit.");
            Console.ReadLine();
        }
    }
}
