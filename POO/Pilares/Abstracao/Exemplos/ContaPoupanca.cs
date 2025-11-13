namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        private double Taxa = 0.03;
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
            //aplicar a taxa de 3% no saque

            double totalComTaxa = valor + (valor * Taxa);

            if (valor <= 0 || totalComTaxa >= Saldo)
            {
                System.Console.WriteLine("O valor deve ser positivo e ter dinheiro suficiente para o sauqe (Conta Corrente)");
                return;
            }

            //calcular o saque + taxa de saque 

            Saldo -= totalComTaxa;
        }
    }
}