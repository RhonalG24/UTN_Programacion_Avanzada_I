using PracticaOperadores.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores;

public class OperatorsProgram
{
    public static void RunOperatorsProgram()
    {
        Console.WriteLine("\nEnunciados\n");
        int continueProccess = 1;
        while (continueProccess == 1)
        {

            int opcion = GetOption();
            if (opcion == 0)
            {
                return;
            }
            IProgram program = ProgramFactory.MakeProgram(opcion);
            program.Execute();

            //Console.WriteLine("\n¿Desea realizar otra acción? ");
            //Console.WriteLine("1.- Sí");
            //Console.WriteLine("0.- No");
            continueProccess = WantToContinue();
        }

    }
    private static int GetOption()
    {
        Console.WriteLine("Ingrese el número del enunciado que desea ejecutar:");
        Console.WriteLine("1.- 1.a) Programa para sumar");
        Console.WriteLine("2.- 1.b) Programa para restar");
        Console.WriteLine("3.- 1.c) Programa para multiplicar");
        Console.WriteLine("4.- 1.d) Programa para dividir");
        Console.WriteLine("5.- 1.e) Programa para calcular el resto");
        Console.WriteLine("6.- 1.f) Cálculo de un número a una potencia");
        Console.WriteLine("7.- 1.g) Cálculo del promedio entre 3 números");
        Console.WriteLine("8.- 1.h) Cálculo del area de un triángulo");
        Console.WriteLine("9.- 1.i) Cálculo del perimetro de un círculo");
        Console.WriteLine("10.- 1.j) Conversión de grados Celsius a grados Fahrenheit");
        Console.WriteLine("11.- 1.k) Calculadora SOLID");
        Console.WriteLine("12.- 2) Calcular el promedio entre 4 notas");
        Console.WriteLine("13.- 3) Conversión de cm a pulgadas");
        Console.WriteLine("14.- 4) Conversión de pesos a dolares");
        Console.WriteLine("15.- 5) Cálculo de la cuenta del Restaurant");
        Console.WriteLine("16.- 7) Programa del número binario");
        Console.WriteLine("0.- Salir");

        int opcion = NumberUtilities.GetIntInput();
        while (opcion > 16 || opcion < 0)
        {
            Console.WriteLine("Ingrese una opcion válida");
            opcion = NumberUtilities.GetIntInput();
        }
        return opcion;

    }
    public static int WantToContinue()
    {
        int option;

        do
        {
            Console.WriteLine("\n¿Desea realizar otra operación? ");
            Console.WriteLine("1.- Sí");
            Console.WriteLine("0.- No");
            option = NumberUtilities.GetIntInput();
            if (option < 0 || option > 1)
                Console.WriteLine("Ingrese un valor válido\n");
        } while (option < 0 || option > 1);
        return option;
    }

}

