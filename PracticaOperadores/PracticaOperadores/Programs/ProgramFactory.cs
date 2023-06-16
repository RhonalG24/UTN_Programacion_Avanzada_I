using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperadores.Programs
{
    public class ProgramFactory
    {


        public static IProgram MakeProgram(int option)
        {
            switch (option)
            {
                case 1:
                    return new SumarProgram();
                case 2:
                    return new RestarProgram();
                case 3:
                    return new MultiplicarProgram();
                case 4:
                    return new DividirProgram();
                case 5:
                    return new RestoProgram();
                case 6:
                    return new PotenciaProgram();
                case 7:
                    return new PromedioTresNumerosProgram();
                case 8:
                    return new AreaTrianguloProgram();
                case 9:
                    return new PerimetroCirculoProgram();
                case 10:
                    return new CelsiusAFahrenheitProgram();
                case 11:
                    return new CalculadoraSolidProgram();
                case 12:
                    return new PromedioCuatroNumerosProgram();
                case 13:
                    return new CentimetrosAPulgadasProgram();
                case 14:
                    return new PesosADolaresProgram();
                case 15:
                    return new RestaurantProgram();
                default:
                    return new NumeroBinarioProgram();
            }

        }

    }
}
