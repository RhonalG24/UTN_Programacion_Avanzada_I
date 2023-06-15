using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores
{
    public class Restaurant
    {
        private const float HOT_DOGS_PRICE = 2f;
        private const float FRENCH_FRIES_PRICE = 1f;
        private const float SODA_PRICE = 0.85f;
        private const float TIP = 0.1f; //10%

        public static float CalculateBill(int hotDogsQuantity, int frenchFriesQuantity, int sodaQuantity) {
            ICalculator calculator = new Multiplicacion();
            float totalHotDogs = calculator.Calculate(hotDogsQuantity, HOT_DOGS_PRICE);
            float totalHFrenchFries = calculator.Calculate(frenchFriesQuantity, FRENCH_FRIES_PRICE);
            float totalSoda = calculator.Calculate(sodaQuantity, SODA_PRICE);

            calculator = new Suma();
            float bill = 0;
            bill += calculator.Calculate(totalHotDogs, totalHFrenchFries);
            bill = calculator.Calculate(bill, totalSoda);

            calculator = new Multiplicacion();
            float tip = calculator.Calculate(bill, TIP);

            calculator = new Suma();
            bill = calculator.Calculate(bill, tip);
            return bill;
        }

    }
}
