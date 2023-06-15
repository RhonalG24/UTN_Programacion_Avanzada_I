using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores
{
    internal class Resta : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }

        public decimal Calculate(decimal a, decimal b)
        {
            return a - b;
        }

        public float Calculate(float a, float b)
        {
            return a - b;
        }

        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}

