

namespace Encapsulamento
{
    public class Carro
    {
        private string Marca = "";
        private string Modelo = "";
        private int velocidadeAtual;

        public void DefinirMarca(string ma)
        {
            Marca = ma;
        }
        public string ObterMarca()
        {
            return Marca;
        }
        public void DefinirModelo(string mo)
        {
            Modelo = mo;
        }
        public string ObterModelo()
        {
            return Modelo;
        }
        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }
        public void Acelerar(int valor)
        {
            if (valor > 0)
            {
                velocidadeAtual += valor;
            }
            else
            {
                System.Console.WriteLine("Condições inválidas para acelerar!");
            }
        }
        public void Frear(int valor)
        {
            if (velocidadeAtual > 0) velocidadeAtual -= valor;
            else if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
            else
            {
                System.Console.WriteLine("Condições inválidas para frear");
            }

        }
    }
}