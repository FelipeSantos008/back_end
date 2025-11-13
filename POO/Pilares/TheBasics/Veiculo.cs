
namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QtdRodas;

        public void Ligar()
        {
            System.Console.WriteLine("Ligando o veiculo ");
        }
        public void Desligar()
        {
            System.Console.WriteLine("Desligando o veiculo ");
            System.Console.WriteLine(". . .");
            System.Console.WriteLine("Veiculo desligado");
        }
    }
}