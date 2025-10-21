
/* altere o exercício anterior para que cada opção escolhida pelo usuário seja respondida por uma função, ou seja, cada opção deve dar um Console.WriteLine() da opção escolhida.*/

int opcao;

Console.Clear();

do
{

    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("        Bem Vindo, Usuário");
    Console.WriteLine("-------------------------------------------------------");

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine("   1) Opção 1");
    Console.WriteLine("   2) Opção 2");
    Console.WriteLine("   3) Opção 3");
    Console.WriteLine("   0) Sair");

    Console.Write("Digite sua opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            imprimirEscolha1();
            break;
        case 2:
            imprimirEscolha2();
            break;
        case 3:
            imprimirEscolha3();
            break;
        case 0:
            imprimirEscolha4();
            break;
        default:
            opcaoInvalida();
            break;
    }
} while (opcao != 0);

void imprimirEscolha1()
{
    Console.WriteLine("Você escolheu a Opção 1");
}
void imprimirEscolha2()
{
    Console.WriteLine("Você escolheu a Opção 2");
}
void imprimirEscolha3()
{
    Console.WriteLine("Você escolheu a Opção 3");
}
void imprimirEscolha4()
{
    Console.WriteLine("Saindo do programa...");
}

void opcaoInvalida()
{
    Console.WriteLine("Opção inválida!");
}