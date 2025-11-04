using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Estoque;
        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine(@$"   Produto: {Nome}
            Preco do produto: {Preco:F2}
            Quantidade em estoque: {Estoque}");
        }
    }
}
