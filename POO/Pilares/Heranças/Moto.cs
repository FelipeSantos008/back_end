using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Moto : Veiculo
    {
        public string Capacete = "";

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($" Tipo de capacete: {Capacete}");
        }
    }
}