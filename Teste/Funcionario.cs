using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem/100;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido();
        }
    }
}
