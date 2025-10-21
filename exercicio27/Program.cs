int q = 0, i = 1, n = 0;

Console.WriteLine("Quantos números você deseja digitar?");
Console.WriteLine("");
Console.WriteLine("");
q = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

while (i <= q)
{
    Console.WriteLine("Digite um número");
    Console.WriteLine("");
    Console.WriteLine("");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("");
    if (n % 2 == 0)
    {
        Console.WriteLine($"O número {n} é par");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    i++;
}