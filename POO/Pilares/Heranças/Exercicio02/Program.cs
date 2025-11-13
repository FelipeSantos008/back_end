using Exercicio02;
Funcionario f1 = new Funcionario();
f1.Nome = "Jorge Pampa";
f1.SalarioBase = 1485.42f;

System.Console.WriteLine(@$"Nome: {f1.Nome}
Salario do funcionario: {f1.SalarioBase}");

Gerente g1 = new Gerente();
g1.Nome = "Felipe Silva";
g1.SalarioBase = 1485.42f
g1.Bonus = 2095.32f;
g1.CalcularSalario();
System.Console.WriteLine(@$"Nome: {g1.Nome}
Salario do Gerente: {g1.CalcularSalario()}");