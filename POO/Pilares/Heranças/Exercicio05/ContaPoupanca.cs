using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            double Rendimento = Saldo * 1.2f;
            Saldo += Rendimento;
            System.Console.WriteLine($"Rendimento de 2% aplicado: {Rendimento}");
        }

    }
}