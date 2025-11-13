namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine("Auau");
        }
        public override void Mover()
        {
            System.Console.WriteLine("Cachorro se movendo");
        }
    }
}