
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //cria um cosntrutor na classe aluno que recebe o endereço
        //chama o construtor da classe mãe e repassa o endereço para ela
        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}