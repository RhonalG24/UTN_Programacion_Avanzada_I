using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class PerimetroCirculoProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma para el cálculo del perimetro de un círculo.");
            Console.WriteLine("\nIngrese el radio del circulo: ");
            float input1 = NumberUtilities.GetFloatInput();
            Console.WriteLine("\nEl perímetro del círculo es: " + Calculator.Perimetro(input1));
            Console.ReadLine();
        }
    }
}
