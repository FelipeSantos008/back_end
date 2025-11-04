using MetodoConstrutor;

//primeiro metodo construtor
Pessoa3Sobrecargas p1 = new Pessoa3Sobrecargas();
//segundo metodo construtor
Pessoa3Sobrecargas p2 = new Pessoa3Sobrecargas("Matheus Felix");
//terceiro metodo construtor
Pessoa3Sobrecargas p3 = new Pessoa3Sobrecargas("Felipe Silva", 16);

System.Console.WriteLine(@$"Primeira pessoa cadastrada:
                            Nome: {p1.Nome}
                            Idade: {p1.Idade}");

System.Console.WriteLine(@$"Segunda pessoa cadastrada:
                            Nome: {p2.Nome}
                            Idade: {p2.Idade}");

System.Console.WriteLine(@$"Digite o nome da terceira pessoa");
p3.Nome = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine($"Digite a idade da terceira pessoa");
p3.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine(@$"Terceira pessoa cadastrada:
                            Nome: {p3.Nome}
                            Idade: {p3.Idade}");

