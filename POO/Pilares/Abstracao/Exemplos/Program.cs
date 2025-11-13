using Exemplos;

// Cachorro c1 = new Cachorro();
// Gato g1 = new Gato();
// Pessoa p1 = new Pessoa();

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

cc.Sacar(10);
cp.Sacar(5);

System.Console.WriteLine($"Saldo da conta corrente: {cc.Saldo}");
System.Console.WriteLine($"Saldo da conta poupança: {cp.Saldo}");