/*Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes.*/

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