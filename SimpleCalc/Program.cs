/*
Pedir o nome di usuário
Pedir dois numeros e mostrar a soma dos numeros no final*/

using System.Runtime.InteropServices;

string nome;
int numero1;
int numero2;

//pedir os nome pro usuario
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine(); //pede o nome do usuario
//pedir os dois numeros
//somar os dois numeros
//exibir nome e a soma
Console.WriteLine("Digite o primerio numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());


//exibir o maior numero
if (numero1 > numero2)
{
    Console.WriteLine("O primeiro numero é maior: " + numero1);
}
else if (numero1 == numero2)
{
    Console.WriteLine("O primeiro e o segundo numeros são iguais");
}
else
{
        Console.WriteLine($"O segundo numero é o maior: {numero2}");
}
