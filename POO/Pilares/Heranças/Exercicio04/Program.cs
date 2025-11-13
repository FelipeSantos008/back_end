using Exercicio04;

Aluno a1 = new Aluno();
a1.Nome = "Felipe Silva";
a1.Idade = 16;
a1.Curso = "Desenvolvimento de Sistemas";

Professor p1 = new Professor();
p1.Nome = "Mario";
p1.Idade = 52;
p1.Disciplina = "História";

System.Console.WriteLine("-------- Aluno --------");
System.Console.WriteLine();
System.Console.WriteLine(@$"    Nome: {a1.Nome}
Idade: {a1.Idade}
Curso: {a1.Curso}");

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("-------- Professor --------");
System.Console.WriteLine();
System.Console.WriteLine(@$"    Nome: {p1.Nome}
Idade: {p1.Idade}
Disciplina: {p1.Disciplina}");