using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class ConversorDeMoeda
    {
        public static double ConverterMoeda(double cotacao, double qtde)
        {
            double IOF = 0.06;

            return (cotacao * qtde) + (cotacao * qtde) * IOF;
        }


    }
}
