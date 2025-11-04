using System.Security.AccessControl;
using PrimeiraClasse;

// string nome = "Felipe";


// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá usuário";

// cumprimento.SaudarUsuario();
// cumprimento.SaudarComNome("Felipe S. dos Santos");
// Carro c1 = new Carro();

// c1.marca = "Lamborghini";
// c1.modelo = "Urus";
// c1.cor = "Preto";
// c1.qtdPortas = 4;
// c1.qtdRodas = 4;
// c1.Ligar();
// c1.Acelerar();
// c1.Frear();
// c1.Desligar();

// Carro c2 = new Carro();
// c2.marca = "Chevrolet";
// c2.modelo = "Camaro";
// c2.cor = "Amarelo";
// c2.qtdPortas = 2;
// c2.qtdRodas = 4;
// Console.WriteLine($"ligando: {c1.marca}");
// Console.WriteLine($"Acelerando {c2.marca}");
// System.Console.WriteLine($"Freando {c2.modelo}");
// System.Console.WriteLine($"Desligando {c2.cor}");


// System.Console.WriteLine();
// System.Console.WriteLine("Caracteristicas");
// System.Console.WriteLine();

// System.Console.WriteLine($"------------- {c1.marca} -------------");
// Console.WriteLine($"Carro: {c1.marca}");
// System.Console.WriteLine($"Modelo: {c1.modelo}");
// System.Console.WriteLine($"Cor: {c1.cor}");
// System.Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
// System.Console.WriteLine();
// System.Console.WriteLine("---");
// System.Console.WriteLine();

// System.Console.WriteLine($"------------- {c2.marca} -------------");
// Console.WriteLine($"Carro: {c2.marca}");
// System.Console.WriteLine($"Modelo: {c2.modelo}");
// System.Console.WriteLine($"Cor: {c2.cor}");
// System.Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
// System.Console.WriteLine();


//criar uma classe que represente uma moto 
//pelo menos 4 propriedades
//pelo menos 3 métodos

// Moto m1 = new Moto();
// m1.marca = "Yamaha";
// m1.modelo = "Yamaha MT-03";
// m1.cor = "Vermelho";
// m1.qtdRodas = 2;
// m1.Ligar();
// m1.Acelerar();
// m1.Frear();

// System.Console.WriteLine($"------------- {m1.marca} -------------");
// Console.WriteLine($"Moto: {m1.marca}");
// System.Console.WriteLine($"Modelo: {m1.modelo}");
// System.Console.WriteLine($"Cor: {m1.cor}");
// System.Console.WriteLine($"Quantidade de Portas: {m1.qtdRodas}");
// System.Console.WriteLine();
// System.Console.WriteLine("---");
// System.Console.WriteLine();

// g1.capacidade = 1.5;
// g1.marca = "Pacco";
// g1.cor = "Preto";

// System.Console.WriteLine($"Capacidade: {g1.capacidade}");
// System.Console.WriteLine($"Marca: {g1.marca}");
// System.Console.WriteLine($"");
// g1.Abrir();
// g1.Encher();
// g1.Esvaziar();
// g1.Fechar();

Console.Clear();

System.Console.WriteLine($"Olá usuário, iremos criar uma garrafa agora!");

Garrafa g1 = new Garrafa();

System.Console.WriteLine($"Qual a capacidade dessa garrafa?");
g1.capacidade = double.Parse(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Qual o tipo dessa garrafa?");
g1.tipo = Console.ReadLine();

System.Console.WriteLine();
System.Console.WriteLine("Qual a cor dessa garrafa?");
g1.cor = Console.ReadLine();

System.Console.WriteLine();
System.Console.WriteLine("---------- Garrafa ----------");
System.Console.WriteLine($"Capacidade: {g1.capacidade} L");
System.Console.WriteLine($"Tipo: {g1.tipo}");
System.Console.WriteLine($"Cor: {g1.cor}");
System.Console.WriteLine();
