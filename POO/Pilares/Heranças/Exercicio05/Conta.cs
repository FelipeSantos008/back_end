using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Conta
    {
        public  int Numero;
        public double Saldo;

         public void Depositar()
        {
            System.Console.WriteLine("Valor do deposito");
            double Valor = double.Parse(Console.ReadLine());
            Saldo += Valor;
        }
        
        public void Sacar()
        {
            System.Console.WriteLine("Valor de saque");
            double Valor = double.Parse(Console.ReadLine());
            Saldo -= Valor;
        }
    }
}