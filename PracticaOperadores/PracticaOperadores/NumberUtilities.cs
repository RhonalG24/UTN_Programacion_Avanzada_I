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

        public static string GetUserInput()
        {
            string input = Console.ReadLine();
            return input;
        }

        public static int GetIntInput()
        {
            int result;
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out result);
            while (!isNumber) {
                Console.WriteLine("Ingrese un valor válido.");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out result);
            }
            return result;
        }

        public static float GetFloatInput()
        {
            float result;
            Console.WriteLine("Use la coma (,) como separador si es un número entero.");
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out result);
            while (!isNumber)
            {
                Console.WriteLine("Ingrese un valor válido.");
                input = Console.ReadLine();
                isNumber = float.TryParse(input, out result);
            }
            return result;
        }

        public static void GetTwoFloatsInput(float input1, float input2)
        {
            Console.WriteLine("Ingrese el primer número");
            input1 = GetFloatInput();
            Console.WriteLine("Ingrese el segundo número");
            input2 = GetFloatInput();
        }
    }
}
