using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Exercicio02
{

    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        //sobrecarga do construtor - obriga a passar os dados na criação do objeto
        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }
        public void Imprimir()
        {
            CalcularValorDivida();
            System.Console.WriteLine($@"
    Credor: {Credor}
    Devedor: {Devedor}
    Dias de Atraso: {DiasDeAtraso} dia(s)
    Valor: {Valor:F2}
    Juros: {(Juros * DiasDeAtraso):F2}
    Total com Júros: R${Valor:F2}
            ");
        }
        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if (DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}