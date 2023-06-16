using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class PromedioCuatroNumerosProgram : IProgram
    {
        public void Execute()
        {
            //Promedio de 4 numeros
            Console.WriteLine("\nPrograma para calcular el promedio entre 4 notas ");
            float result = Calculator.CalcularPromedio(4);
            Console.WriteLine("\nEl promedio es: " + result);
            Console.ReadLine();
        }
    }
}
