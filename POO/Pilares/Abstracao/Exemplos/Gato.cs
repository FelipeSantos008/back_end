using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine("Miau");
        }
        public override void Mover()
        {
            System.Console.WriteLine("Gato Pulando");
        }
    }
}