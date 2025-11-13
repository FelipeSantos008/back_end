namespace Exemplos
{
    public abstract class ContaBancaria
    {

        public double Saldo;
        public double Taxa = 5;
        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
    }
}