using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Carro : Veiculo
    {
        public int QtdPorta;
        public override void MostrarInfo()
        {
            System.Console.WriteLine(@$"Marca: {Marca}
            Modelo: {Modelo}");
            System.Console.WriteLine($" tipo de capacete: {QtdPorta}");
        }
    }
}