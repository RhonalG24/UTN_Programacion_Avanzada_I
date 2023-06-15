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
        float a = 10;
        float b = 5;
        float cero = 0;
        float c = 3;


        ICalculator calculator;
        Console.WriteLine("Suma de " + a + " + " + b + ":");
        Console.WriteLine(Calculator.Sumar(a, b));
        Console.WriteLine("Con una instancia de la clase Suma:");
        calculator = new Suma();
        Console.WriteLine(calculator.Calculate(a, b));

        Console.WriteLine("\nResta de " + a + " - " + b + ":");
        Console.WriteLine(Calculator.Restar(a, b));
        Console.WriteLine("Con una instancia de la clase Resta:");
        calculator = new Resta();
        Console.WriteLine(calculator.Calculate(a, b));

        Console.ReadLine();
        Console.WriteLine("\nMultiplicación de " + a + " * " + b + ":");
        Console.WriteLine(Calculator.Multiplicar(a, b));
        Console.WriteLine("Con una instancia de la clase Multiplicacion:");
        calculator = new Multiplicacion();
        Console.WriteLine(calculator.Calculate(a, b));


        try {
            Console.WriteLine("\nDivisión de " + a + " / " + b + ":");
            Console.WriteLine(Calculator.Dividir(a, b));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        try
        {
            Console.WriteLine("Con una instancia de la clase Division:");
            calculator = new Division();
            Console.WriteLine(calculator.Calculate(a, b));
        } catch (Exception ex) { 
            Console.WriteLine(ex.Message); 
        }
        try
        {

            Console.WriteLine("\nDivisión de " + a + " / " + cero + ":");
            Console.WriteLine(Calculator.Dividir(a, cero));
            } catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
        try
        {
            Console.WriteLine("Con una instancia de la clase Division:");
            Console.WriteLine(calculator.Calculate(a, cero));
        } catch (Exception ex) { 
            Console.WriteLine(ex.Message); 
        }

        Console.ReadLine();
        try
        {
            Console.WriteLine("\nResto de " + a + " / " + b + ":");
            Console.WriteLine(Calculator.Resto(a, b));

            Console.WriteLine("\nResto de " + a + " / " + cero + ":");
            Console.WriteLine(Calculator.Resto(a, cero));

            Console.WriteLine("\nResto de " + a + " / " + c + ":");
            Console.WriteLine(Calculator.Resto(a, c));
        } catch (Exception ex) { 
                Console.WriteLine(ex.Message); 
        }
        Console.ReadLine();

        Console.WriteLine("\nCálculo de " + a + " al cuadrado");
        Console.WriteLine(Calculator.ElevarAlCuadrado((int)a));

        //Console.WriteLine("\nPromedio entre " + a + ", " + b + " y "+ c +":");
        //Console.WriteLine(Calculator.PromedioDeTresNumeros(a,b, c));

        //Promedio de n números
        //List<float> numeros = NumberUtilities.GetNInputs();
        //Console.WriteLine("\nEl promedio entre los números ");
        //numeros.ForEach(x => Console.WriteLine(x));
        //Console.WriteLine("es: ");
        //Console.WriteLine(Calculator.PromedioDeNNumeros(numeros));

        //Promedio de 3 numeros
        Console.WriteLine("\nEl promedio entre 3 números ");
        float result = Calculator.CalcularPromedio(3);
        Console.WriteLine("El promedio es: " + result);


        //Calculo del area de un tríangulo
        Console.WriteLine("\nCálculo del area de un triángulo..");
        Console.WriteLine("\nIngrese la base del triángulo: ");
        float input1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nIngrese la altura del triángulo: ");
        float input2 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nEl area del triángulo es: " + Calculator.AreaTriangulo(input1, input2));

        Console.WriteLine("\nCálculo del perimetro de un círculo..");
        Console.WriteLine("\nIngrese el radio del circulo: ");
        input1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nEl perímetro del círculo es: " + Calculator.Perimetro(input1));

        Console.WriteLine("\nConversión de grados Celsius a grados Fahrenheit..");
        Console.WriteLine("\nIngrese la temperatura en grados Celsius: ");
        input1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\n" + input1 +"° Celsius es equivalente a " + Calculator.CelsiusAFahrenheit(input1) + "° Fahrenheit.");


        //cm a pulgadas
        Console.WriteLine("cm a pulgadas");
        Console.WriteLine("Ingrese un valor en cm para convertirlo a pulgadas: ");
        float inch = float.Parse(Console.ReadLine());
        Console.WriteLine(inch + " cm son " + NumberUtilities.InchesToString(inch) + "\n");
        Console.WriteLine("Ingrese un valor en cm para convertirlo a pulgadas: ");
        float inch2 = float.Parse(Console.ReadLine());
        Console.WriteLine(inch + " cm son " + NumberUtilities.InchesToString(inch2) + "\n");

        //pesos a dolares
        Console.WriteLine("Ingrese el valor en pesos:");
        float pesos = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cotización actual (valor del peso por dolar):");
        float cotizacion = float.Parse(Console.ReadLine());
        Console.WriteLine(pesos + " pesos equivalen a " + Calculator.PesosADolares(pesos, cotizacion) + " dolares. \n");

        //Cuenta del Restaurante
        Console.WriteLine("Ingrese la cantidad de hot dogs: ");
        int hotdogs = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de papas: ");
        int papas = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de sodas: ");
        int sodas = int.Parse(Console.ReadLine());
        Console.WriteLine("La cuenta es: $" + Restaurant.CalculateBill(hotdogs, papas, sodas) + "\n");

    }

    }

