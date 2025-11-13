//namespace pode ser considerado como a pasra do projeto
//namespace é o modulo do sistema       
namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        //endereço
        public Endereco EnderecoCompleto;

        //método construtor

        public Pessoa(Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }
        public void Falar()
        {
            System.Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }
        public void Envelhecer()
        {
            Idade++;
        }
    }
}