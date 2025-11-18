using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public double Raio;
        public void CalcularArea()
        {
            double AreaCirculo = Math.PI * Math.Pow(Raio, 2);
            System.Console.WriteLine($"Area do circulo: {AreaCirculo}");
        }
    }
}