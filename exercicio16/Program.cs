int cargo;
double salario = 0.0;
double salarioReajustado;

Console.WriteLine("Escolha um dos cargos abaixo");

Console.WriteLine("1 - Produção");
Console.WriteLine("2 - Administrativo");
Console.WriteLine("3 - Diretoria");

cargo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o seu salario");
salario = double.Parse(Console.ReadLine());


if (cargo == 1)
{
    Console.WriteLine("Cargo: Produção");
    salarioReajustado = salario + 1.065;
    Console.WriteLine($"Novo salario: {salarioReajustado}");
}
else if (cargo == 2)
{
    Console.WriteLine("Cargo: Adminitrativo");
    salarioReajustado = salario + 1.075;
    Console.WriteLine($"Novo salario: {salarioReajustado}");
} else
{
    Console.WriteLine("Cargo: Diretoria");
    salarioReajustado = salario + 1.12;
    Console.WriteLine($"Novo salario: {salarioReajustado}");
} 






