using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class PromedioTresNumerosProgram : IProgram
    {
        public void Execute()
        {
            //Promedio de 3 numeros
            Console.WriteLine("\nPrograma para calcular el promedio entre 3 números ");
            float result = Calculator.CalcularPromedio(3);
            Console.WriteLine("\nEl promedio es: " + result);
            Console.ReadLine();
        }
    }
}
