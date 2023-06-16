using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class NumeroBinarioProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma del número binario. Input: -7\n");
            int bin = -7;
            Console.WriteLine("\nNúmero en base 10: " + bin + "\n");
            Console.WriteLine(bin + " en base 2: ");
            Console.WriteLine(Convert.ToString(bin, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine("\nDesplazando el bit más significaivo hacia la izquierda: ");
            Console.WriteLine(Convert.ToString(bin << 1, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine("\nAhora el resultado del desplazamiento en base 10: ");
            Console.WriteLine(Convert.ToString(bin << 1, toBase: 10).PadLeft(2, '0'));
            Console.ReadLine();
        }
    }
}
