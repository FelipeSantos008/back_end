
namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
        public string Nome = "";
        public int Idade;

        //métodos construtores - 3 Sobrecargas
        public Pessoa3Sobrecargas()
        {
            Nome = "";
            Idade = 0;
        }

        public Pessoa3Sobrecargas(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pessoa3Sobrecargas(string n, int i)
        {
            Nome = n; //inicializa com o valror de n
            Idade = i; //inicializa com o valror de i
        }
        
            public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
