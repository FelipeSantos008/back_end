ConsoleKey.Clear();
Console.WriteLine("Digite seu nome ");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar boas vindas a você!!");

Console.WriteLine("por favor escolha uma opção abaico:");
Console.WriteLine("1 - Saudar com nome"); //Receba o nome por parâmetro e digitar a saudação dentro da função
Console.WriteLine("1 - Saudar com sobrenome"); //Receba o sobrenome por parâmetro e digitar a saudação dentro da função
Console.WriteLine("1 - Saudar com nome completo"); //Receba o nome e sobrenome e devolve o nome completo
Console.WriteLine("1 - Apenas saudação genérica"); //Só devolve um texto de saudação genérico
Console.Clear();

int opcao = 0;
switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudacaoComNome(nome);
        break;
    case 2:
        SaudacaoComSobrenome(sobrenome);
        break;
    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");                                                             
        break;
    default:
        break;
}

//função que escreve uma saudação de forma genérica
void SaudacaoGenerica()
{
    Console.WriteLine("Olá, seja bem vindo ao nosso programa, tenha um ótimo dia:");
}

//recebe o noe e escreve uma saudação
void SaudacaoComNome (string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    //return nomeRecebido + "" + sobrenomeRecebido;
    return $"{nomeRecebido} {sobrenomeRecebido}";
}

void SaudacaoComSobrenome()
{
    Console.WriteLine($"Olá, seja bem-vindo {sobrenomeRecebido}");
}