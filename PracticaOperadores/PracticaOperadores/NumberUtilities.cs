using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores
{
    public class NumberUtilities
    {
        //public static List<float> GetNInputs() {
        //    List<float> inputs = new List<float>();
        //    string input;
        //    Console.WriteLine("Ingrese un numero: \n");
        //    input = Console.ReadLine();
        //    bool isN = input.Equals("n") || input.StartsWith("n");
        //    while (!isN){
        //        float numberInput = float.Parse(input);
        //        inputs.Add(numberInput);

        //        Console.WriteLine("Ingrese otro numero o 'n' para terminar: \n");
        //        input = Console.ReadLine();
        //    };

        //    return inputs; 
        //}

        public static List<float> GetNInputs()
        {
            List<float> inputs = new List<float>();
            float input;
            Console.WriteLine("\nIngrese un número:");
            input = float.Parse(Console.ReadLine());
            while (input != 0)
            {
                inputs.Add(input);

                Console.WriteLine("\nIngrese otro número o 0 para terminar:");
                input = float.Parse(Console.ReadLine());
            };

            return inputs;
        }

        public static string InchesToString(float inch) {
            string inchString = Math.Round(Calculator.CentimetrosAPulgadas(inch), 4).ToString() + " in";
            return inchString;
        }
    }
}
