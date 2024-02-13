using Imc.Enums;
using Imc.Models;

namespace Imc.Services
{
    public class ImcService
    {
        public EResultadoImc CalcularIMC(ImcModel model) 
        {
            EResultadoImc resultado = EResultadoImc.NORMAL;
            double? imc = model.Peso / (model.AlturaEmMetros * model.AlturaEmMetros);

            if (model.MaiorDe65)
            {
                switch (imc)
                {
                    case < 22:
                        resultado = EResultadoImc.BAIXO; break;
                    case <= 27:
                        resultado = EResultadoImc.NORMAL; break;
                    case <= 29.99:
                        resultado = EResultadoImc.SOBREPESO; break;
                    case >= 30:
                        resultado = EResultadoImc.OBESIDADE; break;
                    default:
                        break;
                }

            }
            else
            {
                switch (imc)
                {
                    case <= 18.5:
                        resultado = EResultadoImc.BAIXO; break;
                    case <= 24.99:
                        resultado = EResultadoImc.NORMAL; break;
                    case <= 29.99:
                        resultado = EResultadoImc.SOBREPESO; break;
                    case >= 30:
                        resultado = EResultadoImc.OBESIDADE; break;
                    default:
                        break;
                }
            }
           

            return resultado;
        }
    }
}

