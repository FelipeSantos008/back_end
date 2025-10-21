Console.WriteLine("Quantas repetições você quer que o programa faça?");
int r = int.Parse(Console.ReadLine());
int n1, n2, q = 0;

while (q < r)
{
    Console.WriteLine("Digite dois numeros");
    n1 = int.Parse(Console.ReadLine());
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O primeiro numero é maior: {n1}");
    }
    else if (n2 > n1)
    {
        Console.WriteLine($"O segundo numero é maior: {n2}");
    } else
    {
        Console.WriteLine($"Os numeros são iguais");
    }

    q++;
}