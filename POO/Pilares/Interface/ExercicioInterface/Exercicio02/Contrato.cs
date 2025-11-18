using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato (string contratante, string contratada, string txtclausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtclausulas;
        }
        public void Imprimir()
        {
    System.Console.WriteLine(@$"
    Contratante: {Contratante}
    Contratada: {PrestadorServico}
    Clausulas de Contrato: 
    
    {TextoClausulas}

    --
            ");
        }
    }
}