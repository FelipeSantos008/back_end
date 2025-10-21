double nota1;
double nota2;
double nota3;
double nota4;

string nomeAluno;

Console.WriteLine("Digite o nome do aluno");
nomeAluno = Console.ReadLine();

Console.WriteLine("Digite as 4 notas do aluno");
nota1 = double.Parse(Console.ReadLine());
nota2 = double.Parse(Console.ReadLine());
nota3 = double.Parse(Console.ReadLine());
nota4 = double.Parse(Console.ReadLine());

double mediaAritimetica = (nota1 + nota2 + nota3 + nota4) / 4;

if (mediaAritimetica > 7)
{
    Console.WriteLine($"Nota final: {mediaAritimetica}");
    Console.WriteLine("Aprovado!");
} else if (mediaAritimetica >= 5 && mediaAritimetica <= 7)
{
    Console.WriteLine($"Nota final: {mediaAritimetica}");
    Console.WriteLine("Fará recuperação");
} else
{
    Console.WriteLine($"Nota final: {mediaAritimetica}");
    Console.WriteLine("Reprovado!!"); 
}