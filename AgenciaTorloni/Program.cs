using System.ComponentModel;
using System.Data.Common;
using System.Reflection.PortableExecutable;

string[] nomes = new string[3];
double[] saldo = new double[3];
int totalCliente = 0;
int opcao = -1;


do
{
    Console.Clear();
    Console.WriteLine("==== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine("");

    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Cliente");
    Console.WriteLine($"0) Sair");
    Console.Write($"\nDigite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;

        case 1:
            CadastroCliente();
            break;

        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarCliente();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();

} while (opcao != 0);


void CadastroCliente()
{
    if (totalCliente >= 3)
    {
        Console.WriteLine("Numero de Clientes excedido");
        return;
    }
    Console.WriteLine("Digite o nome do cliente");
    nomes[totalCliente] = Console.ReadLine(); //guarda o nome no array
    saldo[totalCliente] = 0; //inicia o saldo zerado
    totalCliente++;

    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Há {totalCliente} cliente(s) cadastrado(s) no sistema!");

}
void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write("Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldo[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R${valorDeposito} realizado");
}

void Sacar()
{
    //vai buscar o cliente
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    //pedir o valolr de saque
    Console.Write($"Valor do saque: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    //validar se poode sacar ou não
    if (saldo[idCliente] >= valorSolicitado)
    {//saldo permite saque

        //atualizar o saldo da conta - debita o dinherio da conta do cliente
        saldo[idCliente] -= valorSolicitado;
        Console.WriteLine("Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Saldo insuficiente");
    }
}
void Transferir()
{
    //buscar cliente - cliente de origem
    //buscar cliente - conta de destino
    //pedir o vallor do saque
    //verificar se a conta de origem te  saldo para transferir 
    //se tiver, transfere (debita da conta de origem e adiciona o saldo na conta destino)
    Console.WriteLine("=== Transferência");
    Console.WriteLine("Conta de Origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }

    Console.WriteLine("Conta de Destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write("Valor para transferir: ");
    double valor = double.Parse(Console.ReadLine());

    if (saldo[idClienteOrigem] >= valor)
    {
        saldo[idClienteOrigem] -= valor;
        saldo[idClienteDestino] += valor;
        Console.WriteLine("Transferência Concluída!");
    }
    else
    {
        Console.WriteLine("Saldo Insuficiente");
    }

}
void ListarCliente()
{
    Console.WriteLine("=== Lista de Clientes ===");
    Console.WriteLine("");

    for (int i = 0; i < totalCliente; i++)
    {
        Console.Write($"    Nome: {nomes[i]}  |");
        Console.WriteLine($"   Saldo: R${saldo[i]}");
        Console.WriteLine($"");
    }

}

int BuscarCliente()
{
    ListarCliente(); //desenha a lista de clientes
    Console.Write("digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalCliente)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1; //cliente não encontrado
    }

    return idCliente;//aqui vai sesr devolvido o id do cliente (indice do array onde ele está cadastrado)
}