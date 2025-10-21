//faça um programa que receba 3 numeros interiros e imprima na tela
//a somatória total dos numeros

int n, resultado = 0;

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine("Digite o numero");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}
Console.WriteLine($"A somatória total é: {resultado}")