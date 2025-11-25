// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using ClassesEstaticas;
Console.Clear();

// Console.WriteLine("Bem vindo ao programa");
// System.Console.WriteLine();

System.Console.Write($"Digite o primeiro numero: ");
float a = float.Parse(Console.ReadLine());
System.Console.Write($"Digite o segundo numero: ");
float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

//  r = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"Subtração: {r}");

//  r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"Multiplicação: {r}");

//  r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Divisão: {r}");


if (a == b)
{
    System.Console.WriteLine("os dois números são iguais");
}
else
{
    System.Console.WriteLine($"Qual o maior número entre {a} e {b}?");
    System.Console.WriteLine($"Maior: {Math.Max(a, b)}");
    System.Console.WriteLine($"Menor: {Math.Min(a, b)}");
}

