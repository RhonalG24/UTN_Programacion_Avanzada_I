using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class AreaTrianguloProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma para el cálculo del area de un triángulo.");
            Console.WriteLine("\nIngrese la base del triángulo: ");
            float input1 = NumberUtilities.GetIntInput();
            Console.WriteLine("\nIngrese la altura del triángulo: ");
            float input2 = NumberUtilities.GetIntInput();
            Console.WriteLine("\nEl area del triángulo es: " + Calculator.AreaTriangulo(input1, input2));
            Console.ReadLine();
        }
    }
}
