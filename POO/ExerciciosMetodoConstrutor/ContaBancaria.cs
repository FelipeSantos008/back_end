using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular = "";
        public float Saldo;

        public ContaBancaria(string t, float s)
        {
            Titular = t;
            Saldo = s;
        }
        
        public ContaBancaria(string t)
        {
            Titular = t;
            Saldo = 0;
        }
    }
}