using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaOperadores;

public class Calculator
{
    public Calculator() { }

    public static float Sumar(float a, float b)
    {
        return a + b;
    }

    public static float Restar(float a, float b)
    {
        return a - b;
    }

    public static float Multiplicar(float a, float b)
    {
        return a * b;
    }

    public static float Dividir(float a, float b)
    {
        if (b == 0)
        {
            throw new Exception("No se puede dividir entre 0");               
        }
        return a / b;
    }

    public static float Resto(float a, float b)
    {
        if (b == 0)
        {
            throw new Exception("No se puede dividir entre 0");
        }
        return a % b;
    }

    public static int ElevarAlCuadrado(int a)
    {
        return (int)Math.Pow(a, 2);
    }

    public static float PromedioDeTresNumeros(float a, float b, float c)
    {
        return (a + b + c) / 3;
    }

    public static float PromedioDeNNumeros(List<float> array)
    {
        float total = array.Sum();
        return total / array.Count;
    }

    public static float CalcularPromedio(int cantNumeros)
    {
        float input;
        List<float> inputs = new List<float>();
        for (int i = 1; i <= cantNumeros; i++)
        {
            Console.WriteLine("\nIngrese el " + i + "° número:");
            input = float.Parse(Console.ReadLine());
            inputs.Add(input);
        }

        float total = inputs.Sum();
        return total / inputs.Count;
    }
    public static float AreaTriangulo(float b, float h)
    {
        return (b * h) / 2;
    }

    public static float Perimetro(float radio)
    {
        return (float)(2 * Math.PI * radio);
    }

    public static float CelsiusAFahrenheit(float gradosCelsius)
    {
        return (gradosCelsius * 9 / 5) +32; 
    }

    public static float CentimetrosAPulgadas(float cm)
    {
        float inch = cm / 2.54f;
        return inch;
    }

    public static float PesosADolares(float pesos, float cotizacion)
    {
        return (float)(Math.Round(pesos / cotizacion, 4));
    }
}
