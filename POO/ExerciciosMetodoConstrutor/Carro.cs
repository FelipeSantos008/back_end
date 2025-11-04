using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor

{
    public class Carro
    {
        //propriedades
        public int Ano;
        public string Marca = "";
        public string Modelo = "";

        //método construtor
        public Carro(int a, string Ma, string Mo)
        {
            Ano = a;
            Marca = Ma;
            Modelo = Mo;
        }

        //métodos

        public void ExibirDados()
        {
            System.Console.WriteLine(@$"    Ano de lançamento: {Ano}
            Marca do carro: {Marca}
            Modelo do carro: {Modelo}");
        }
        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine("Carro Freando");
        }

        public void Ligar()
        {
            Console.WriteLine("Carro Ligando");
        }
        public void Desligar()
        {
            Console.WriteLine("Carro Desligando");
        }
    }
}

