using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string textoRelatorio = "";
        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            textoRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            System.Console.WriteLine($"Responsavel: {Nome}");
            System.Console.WriteLine(textoRelatorio);
            System.Console.WriteLine("--fim--");
        }
    }
}