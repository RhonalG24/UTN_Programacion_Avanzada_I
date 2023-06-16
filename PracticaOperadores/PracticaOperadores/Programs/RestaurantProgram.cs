using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class RestaurantProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma de la cuenta del Restaurante.\n");
            Console.WriteLine("\nIngrese la cantidad de hot dogs: ");
            int hotdogs = NumberUtilities.GetIntInput();
            Console.WriteLine("\nIngrese la cantidad de papas: ");
            int papas = NumberUtilities.GetIntInput();
            Console.WriteLine("\nIngrese la cantidad de sodas: ");
            int sodas = NumberUtilities.GetIntInput();
            Console.WriteLine("\nLa cuenta es: $" + Restaurant.CalculateBill(hotdogs, papas, sodas) + "\n");
            Console.ReadLine();
        }
    }
}
