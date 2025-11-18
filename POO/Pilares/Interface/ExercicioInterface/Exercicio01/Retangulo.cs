using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public double Largura;
        public double Altura;
        public void CalcularArea()
        {
            double AreaRetangulo = Largura * Altura;
            System.Console.WriteLine($"Area do Retangulo: {AreaRetangulo}");
        }
    }
}