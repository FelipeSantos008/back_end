using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Animal
    {
        //metodo virtual
        public virtual void FazerSom()
        {
            System.Console.WriteLine("Som do Animal");
        }
    }
}