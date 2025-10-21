/* Baseado no programa do exercício número 9, crie um programa que contenha o menu para os exercícios de 1 a 6, onde cada programa/menu deve executar uma função.*/

int exercício;

Console.Clear();

do
{
    Console.WriteLine("");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("        Bem Vindo, Usuário");
    Console.WriteLine("-------------------------------------------------------");

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Escolha um exercício no menu abaixo:");
    Console.WriteLine("   1) Exercício 1");
    Console.WriteLine("   2) Exercício 2");
    Console.WriteLine("   3) Exercício 3");
    Console.WriteLine("   4) Exercício 4");
    Console.WriteLine("   5) Exercício 5");
    Console.WriteLine("   6) Exercício 6");

    Console.Write("Digite sua opção: ");
    exercício = int.Parse(Console.ReadLine());

    switch (exercício)
    {
        case 1:
            exercício1();
            break;
        case 2:
            exercício2();
            break;
        case 3:
            exercício3();
            break;
        case 4:
            exercício4();
            break;
        case 5:
            exercício5();
            break;
        case 6:
            exercício6();
            break;
        default:
            opcaoInvalida();
            break;
    }


} while (exercício != 0);

void exercício1()
{
    double salario = 0.0, gasto = 0.0;

    Console.WriteLine("Informe o salário recebido");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o total gasto");
    gasto = double.Parse(Console.ReadLine());

    if (salario > gasto)
    {
        Console.WriteLine("Gastos dentro do orçamento");
    }
    else
    {
        Console.WriteLine("Orçamento estourado");
    }

}
void exercício2()
{
    int time1, time2;

    Console.Write("Gols do time 1: ");
    time1 = int.Parse(Console.ReadLine());

    Console.Write("Gols do time 2: ");
    time2 = int.Parse(Console.ReadLine());

    if (time1 > time2)
        Console.WriteLine("Time 1 venceu!");
    else if (time2 > time1)
        Console.WriteLine("Time 2 venceu!");
    else
        Console.WriteLine("Empate!");
}
void exercício3()
{
    double lado1 = 0;
    double lado2 = 0;
    double lado3 = 0;

    Console.WriteLine("Digite a medida do primeiro lado.");
    lado1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a medida do segundo lado.");
    lado2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a medida do terceiro lado.");
    lado3 = double.Parse(Console.ReadLine());

    Console.WriteLine($"Lado 1: {lado1}");
    Console.WriteLine($"Lado 2: {lado2}");
    Console.WriteLine($"Lado 3: {lado3}");

    if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
    {
        if (lado1 == lado2 && lado2 == lado3)
        {

            Console.WriteLine("Triângulo Equilátero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("Triângulo Isósceles");
        }
        else
        {
            Console.WriteLine("Triângulo Escaleno");
        }
    }
}
void exercício4()
{
    int senha;

    Console.WriteLine("Digite a senha");
    senha = int.Parse(Console.ReadLine());

    if (senha == 1234)
    {
        Console.WriteLine("ACESSO    PERMITIDO ");
    }
    else
    {
        Console.WriteLine("ACESSO    NEGADO");
    }
}
void exercício5()
{
    Console.Write("Digite o número de maçãs compradas: ");
    int quantidade = int.Parse(Console.ReadLine());

    double preco;

    // Verifica se foram compradas pelo menos 12 maçãs
    if (quantidade >= 12)
    {
        preco = 0.25;
    }
    else
    {
        preco = 0.30;
    }

    // Calcula o valor total
    double total = quantidade * preco;

    // Exibe o resultado
    Console.WriteLine($"O valor total da compra é: R$ {total}");

}
void exercício6()
{
    // Entrada de dados
    Console.Write("Digite a média do aluno: ");
    double media = double.Parse(Console.ReadLine());

    Console.Write("Digite a frequência do aluno (em %): ");
    double frequencia = double.Parse(Console.ReadLine());

    // Estruturas de decisão
    if (frequencia < 75)
    {
        Console.WriteLine("Aluno REPROVADO por frequência.");
    }
    else if (media >= 7.0)
    {
        Console.WriteLine("Aluno APROVADO.");
    }
    else if (media >= 3.0)
    {
        Console.WriteLine("Aluno em RECUPERAÇÃO.");
    }
    else
    {
        Console.WriteLine("Aluno REPROVADO por média.");
    }


}

void opcaoInvalida()
{
    Console.WriteLine("Opção inválida!");
}