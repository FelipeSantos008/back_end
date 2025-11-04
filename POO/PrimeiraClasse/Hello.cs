namespace PrimeiraClasse
{
    class Hello
    {
        //propriedades/caracteristicas - variáveis internas dessa classe
        public string TextoHello = "";

        //Métodos/Comportamentos/Ações - funções internas dessa classe
        public void SaudarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaudarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }//fim da classe 
}//fim do namespace
