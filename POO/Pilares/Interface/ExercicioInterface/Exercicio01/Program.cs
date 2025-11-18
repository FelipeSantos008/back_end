using Exercicio01;

Console.Clear();

Retangulo r1 = new Retangulo();
System.Console.WriteLine("Digite a largura do retangulo");
r1.Largura = double.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine("Digite a altura do retangulo");
r1.Altura = double.Parse(Console.ReadLine());
r1.CalcularArea();

System.Console.WriteLine();
Circulo c1 = new Circulo();
System.Console.WriteLine("Digite o raio do circulo");
c1.Raio = double.Parse(Console.ReadLine());
c1.CalcularArea();