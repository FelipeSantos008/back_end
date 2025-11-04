

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade = 0;

        public void Falar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}");
        }
        
        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                System.Console.WriteLine("Idade tem que ser positiva!");
                return Idade;
            }
            Idade += _anos;

            return Idade;
        }
    }
}