using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class CentimetrosAPulgadasProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma de conversión de cm a pulgadas");
            Console.WriteLine("\nIngrese un valor en cm para convertirlo a pulgadas: ");
            float inch = NumberUtilities.GetIntInput();
            Console.WriteLine("\n"+inch + " cm son " + NumberUtilities.InchesToString(inch) + "\n");
            Console.ReadLine();
        }
    }
}
