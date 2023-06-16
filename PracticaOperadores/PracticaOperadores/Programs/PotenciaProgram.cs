using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class PotenciaProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nCálculo de un número a una potencia");
            Console.WriteLine("\nIngrese el número base:");
            int a = NumberUtilities.GetIntInput();
            Console.WriteLine("\nIngrese el número de la potencia:");
            int b = NumberUtilities.GetIntInput();
            Console.WriteLine("\nEl resultado de " + a + " elevado a la " + b +" es:");
            Console.WriteLine(Calculator.ElevarAUnaPotencia(a, b));
            Console.ReadLine();
        }
    }
}
