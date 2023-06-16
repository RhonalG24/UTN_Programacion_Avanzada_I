using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    internal class CalculadoraSolidProgram : IProgram
    {
        public void Execute()
        {
            Console.WriteLine("\nPrograma de calculadora SOLID.\n");
            int continueProccess = 1;
            while (continueProccess == 1) { 

                int operador = GetOption();
                if(operador == 0)
                {
                    Console.WriteLine("\nHa salido de la calculadora SOLID.\n");
                    return;
                }
                ICalculator calculator = GetCalculator(operador);             

                Console.WriteLine("\nIngrese el primer número");
                float a = NumberUtilities.GetFloatInput();
                Console.WriteLine("\nIngrese el segundo número");
                float b = NumberUtilities.GetFloatInput();

                Console.WriteLine("\nResultado:");

                try { 
                    Console.WriteLine(calculator.Calculate(a, b));
                    }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();

                Console.WriteLine("\n¿Desea realizar otra operación? ");
                Console.WriteLine("1.- Sí");
                Console.WriteLine("0.- No");
                continueProccess = NumberUtilities.GetIntInput();
            }
            Console.WriteLine("\nHa salido de la calculadora SOLID.\n");
        }

        private int GetOption()
        {
            Console.WriteLine("Ingrese el número de la operación que desea realizar:");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
            Console.WriteLine("0.- Salir");

            int operador = NumberUtilities.GetIntInput();
            while (operador > 4 || operador < 0)
            {
                Console.WriteLine("Ingrese una opcion válida");
                operador = NumberUtilities.GetIntInput();
            }
            return operador;

        }

        private ICalculator GetCalculator(int operador)
        {
            switch (operador)
            {
                case 1:
                    return new Suma();
                case 2:
                    return new Resta();
                case 3:
                    return new Multiplicacion();
                default:
                    return new Division();
            }
        }
    }
}
