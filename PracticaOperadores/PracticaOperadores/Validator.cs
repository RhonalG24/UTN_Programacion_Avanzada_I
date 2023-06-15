using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores
{
    public class Validator
    {
        public static bool ZeroValidator(int a) {
            if (a == 0)
            {
                return true;
            }
            return false;
        }
        public static bool ZeroValidator(float a)
        {
            if (a == 0)
            {
                return true;
            }
            return false;
        }
        public static bool ZeroValidator(decimal a)
        {
            if (a == 0)
            {
                return true;
            }
            return false;
        }
        public static bool ZeroValidator(double a)
        {
            if (a == 0)
            {
                return true;
            }
            return false;
        }
    }
}
