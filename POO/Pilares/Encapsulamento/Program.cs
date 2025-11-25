using Encapsulamento;
Console.Clear();

// float dinheiro = -200;

// ContaBancaria c1 = new ContaBancaria();
// ContaBancaria c2 = new ContaBancaria(1000);


// // c1.Depositar(dinheiro);
// // System.Console.WriteLine($"Saldo da conta do Edu: R${c1.GetSaldo()}");
// // System.Console.WriteLine($"Saldo da conta de Felipe: R${c2.GetSaldo()}");

// c2.Sacar(200);
// System.Console.WriteLine($"Novo saldo da conta de Felipe: {c2.GetSaldo()}");

Carro car1 = new Carro();
car1.DefinirMarca("Toyota");
car1.DefinirModelo("Corolla");
System.Console.WriteLine($@"Marca do carro: {car1.ObterMarca()}
Modelo do carro: {car1.ObterModelo()}");
System.Console.WriteLine();

System.Console.WriteLine("-------- VELOCIMETRO --------");

car1.Acelerar(12);
System.Console.WriteLine($"Velocidade atual: {car1.ObterVelocidade()}");

car1.Acelerar(13);
System.Console.WriteLine($"Velocidade atual: {car1.ObterVelocidade()}");

car1.Acelerar(14);
System.Console.WriteLine($"Velocidade atual: {car1.ObterVelocidade()}");
System.Console.WriteLine();

car1.Frear(23);
System.Console.WriteLine($"Velocidade atual: {car1.ObterVelocidade()}");

car1.Frear(23);
System.Console.WriteLine($"Velocidade atual: {car1.ObterVelocidade()}");
