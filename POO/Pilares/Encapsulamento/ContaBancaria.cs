


namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        //construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
             if (saldoInicial >= 0)
            {
            Saldo = saldoInicial;
            return;
            }
        }
        //Método público que configura/guarda o Saldo
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
            Saldo = valor;
            return;
            }
            System.Console.WriteLine("Valor para depósito inválido");
        }
        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque efetuado com sucesso!");
                return;
            }
            System.Console.WriteLine("Valor de saque inválido");
        }

        //Método público que retorna o saldo
        public float GetSaldo()
        {
            return Saldo;
        }

      
    }
}