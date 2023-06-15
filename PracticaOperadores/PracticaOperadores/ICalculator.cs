using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores
{
    internal interface ICalculator
    {
        public int Calculate(int a, int b);
        public decimal Calculate(decimal a, decimal b);
        public float Calculate(float a, float b);
        public double Calculate(double a, double b);

    }
}
