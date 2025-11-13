namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
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
            //aplicar a taxa de 3% no saque

            double totalComTaxa = valor * 0.03;

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