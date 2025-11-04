
namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

        //método construtor de Pessoa
        //possui paramêtros 
        //paramêtros representam os valores nome e idade, ou seja, estamos inicializando valores para as propriedades nome e idade

        public Pessoa(string n, int i)
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
