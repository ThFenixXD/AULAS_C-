using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class ContaBancaria
    {
        public int NumeroConta {get; private set;}

        public string NomeTitular { get; set; }

        public double SaldoConta { get; private set; }

        public int TaxaSaque = 5;

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            //SaldoConta += depositoInicial;
            DepositoBancario(depositoInicial);
        }

        //public int NumeroConta
        //{
        //    get
        //    {
        //        return _numeroConta;
        //    }

        //    set
        //    {
        //        if (value == null)
        //        {
        //            if (value > 1)
        //            {
        //                _numeroConta = value;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Número Inválido!!!");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Proibido alterar número da Conta!!!");
        //        }
        //    }
        //}

        public void DepositoBancario(double valorDeposito)
        {
            SaldoConta += valorDeposito;
        }

        public void SaqueBancario(double valorSaque)
        {
            if (valorSaque != 0)
            {
                SaldoConta -= (valorSaque + TaxaSaque);
            }
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + 
                   ", Titular: " + NomeTitular +
                   ", Saldo: $ " + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }

        //CORREÇÃO

        //public int NumeroConta { get; private set};

        //public string NomeTitular { get; set; }

        //public double SaldoConta { get; private set; }

        //public ContaBancaria (int numeroConta, string nomeTitular)
        //{
        //    NumeroConta = numeroConta;
        //    NomeTitular = nomeTitular;

        //}


    }
}
