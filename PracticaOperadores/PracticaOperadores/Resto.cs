using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores
{
    internal class Resto : ICalculator
    {

        string error0Message = "No se puede dividir entre 0";
        public int Calculate(int a, int b)
        {
            if (Validator.ZeroValidator(b))
            {
                throw new DivideByZeroException(error0Message);
            }
            return a % b;
        }

        public decimal Calculate(decimal a, decimal b)
        {
            if (Validator.ZeroValidator(b))
            {
                throw new DivideByZeroException(error0Message);
            }
            return a % b;
        }

        public float Calculate(float a, float b)
        {
            if (Validator.ZeroValidator(b))
            {
                throw new DivideByZeroException(error0Message);
            }
            return a % b;
        }

        public double Calculate(double a, double b)
        {
            if (Validator.ZeroValidator(b))
            {
                throw new DivideByZeroException(error0Message);
            }
            return a % b;
        }
    }
}
