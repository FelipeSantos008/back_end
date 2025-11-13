namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                System.Console.WriteLine($"O valor do saque deve ser nauir que R$0,00");
                return; //para a execução do método por aqui
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            //     valor solicitado + taxa de 1%
            double totalComTaxa = valor + (valor * Taxa);

            if (valor <= 0 || totalComTaxa <= Saldo)
            {
                System.Console.WriteLine("O valor deve ser maiuor que R$0,00");
                return;
            }

            //calcular o saque + taxa de saque 

            Saldo -= totalComTaxa;
        }
    }
}