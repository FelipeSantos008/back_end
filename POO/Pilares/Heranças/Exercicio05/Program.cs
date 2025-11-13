using Exercicio05;
Console.Clear();

ContaPoupanca poupanca1 = new ContaPoupanca();
poupanca1.Saldo = 1000.69f;
poupanca1.Numero = 1;

poupanca1.Depositar();
poupanca1.CalcularRendimento();