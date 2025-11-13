namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine("Pessoa falando");
        }

        public override void Mover()
        {
            System.Console.WriteLine("Pessoa andando");
        }
    }
}