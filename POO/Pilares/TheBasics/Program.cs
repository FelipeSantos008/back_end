using System.Collections.Concurrent;
using TheBasics;
Console.Clear();

//array/lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecoFelipe = new Endereco();
// enderecoFelipe.Logradouro = "Rua anny";

// Pessoa felipe = new Pessoa(enderecoFelipe);
// felipe.Nome = "Felipe Silva";
// felipe.Idade = 16;

// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua lá de casa";
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia";
// alexia.Idade = 24;


// //guardando os dados na lista
// peoples.Add(felipe);
// peoples.Add(alexia);

// //percorre a lista
// foreach (Pessoa p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// System.Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da prof(a) {profAlexia.Nome}");

Carro c1 = new Carro();
c1.Marca = "Toyota";
c1.Modelo = "Corolla";
c1.QtdRodas = 4;

System.Console.WriteLine(@$"Primeiro carro:
Marca: {c1.Marca}
Modelo: {c1.Modelo}
Quantidade de rodas: {c1.QtdRodas}");
System.Console.WriteLine();
c1.AbrirPortaMala();
c1.Ligar();
System.Console.WriteLine();

Moto m1 = new Moto();
m1.Marca = "Bajaj";
m1.Modelo = "Dominar 400";
m1.QtdRodas = 2;
System.Console.WriteLine(@$"Primeira moto:
Marca: {m1.Marca}
Modelo: {m1.Modelo}
Quantidade de rodas: {m1.QtdRodas}");
System.Console.WriteLine();
m1.Ligar();
m1.Empinar();