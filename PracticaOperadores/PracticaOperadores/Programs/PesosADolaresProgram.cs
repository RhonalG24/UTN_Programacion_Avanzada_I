using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class PesosADolaresProgram : IProgram
    {
        public void Execute()
        {
            //pesos a dolares
            Console.WriteLine("\nPrograma de conversión de pesos a dolares:");
            Console.WriteLine("\nIngrese el valor en pesos:");
            float pesos = NumberUtilities.GetFloatInput();
            Console.WriteLine("\nIngrese la cotización actual (valor del peso por dolar):");
            float cotizacion = NumberUtilities.GetFloatInput();
            Console.WriteLine("\n"+pesos + " pesos equivalen a " + Calculator.PesosADolares(pesos, cotizacion) + " dolares. \n");
            Console.ReadLine();
        }
    }
}
