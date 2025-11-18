using Exercicio02;

Console.Clear();

//cria uma lista de objetos Fatura
List<IImprimivel> documentos = new List<IImprimivel>();



// Fatura f1 = new Fatura("Eduardo", "Itau", 50, 1);
// f1.Imprimir();
// System.Console.WriteLine();

// Relatorio r1 = new Relatorio("Felipe", "Tirou nota maxima na prova aplicada no dia 26/11");
// r1.Imprimir();
// System.Console.WriteLine();

// Contrato c1 = new Contrato("Felipe", "Jorge", "Diaria no valor de R$210,30");
// c1.Imprimir();
int opcao;
do
{

    System.Console.WriteLine("Menu de Opções:");
    System.Console.WriteLine(@$"
    1) Cadastrar Faturas
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listar faturas
    5) Listar Relatórios
    6) Listar Contratos

    Escolha a opção 
");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            CadastrarRelatorio();
            break;
        case 3:
            CadastrarContrato();
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            System.Console.WriteLine("Listar Relatório");
            break;
        case 6:
            System.Console.WriteLine("Listar Contrato");
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            break;
    }

    System.Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();//para o console para dar tempo de ver as mensagens do programa
} while (opcao != 0);

void CadastrarFatura()
{
    System.Console.WriteLine("Digite o nome do devedor");
    string dev = Console.ReadLine();
    
    System.Console.WriteLine("Digite o nome do credor");
    string cred = Console.ReadLine();
    
    System.Console.WriteLine("Digite o valor da fatura:");
    float valor = float.Parse(Console.ReadLine());
    
    System.Console.WriteLine("Quantos dias a fatura está em atraso?");
    int diasAtraso = int.Parse(Console.ReadLine());


    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    documentos.Add(f);
    System.Console.WriteLine("Fatura cadastrada com sucesso");

}

void CadastrarContrato()
{
    System.Console.WriteLine("Digite o nome do Contratante");
    string contratante = Console.ReadLine();

    System.Console.WriteLine("Digite o  nome do contratado");
    string contratada = Console.ReadLine();

    System.Console.WriteLine("Digite as clausulas do contrato");
    string txtclausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada, txtclausulas);
    documentos.Add(c);

    System.Console.WriteLine("Contrato cadastrado com sucesso");

}

void CadastrarRelatorio()
{
    System.Console.WriteLine("Digite o nome do Responsavel pelo relatório");
    string responsavel = Console.ReadLine();

    System.Console.WriteLine("Digite o texto desse relatório");
    string txtRelatorio = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txtRelatorio);
    documentos.Add(r);
    System.Console.WriteLine("Relatório cadastrado com sucesso");
}

void ListarFaturas()
{
    System.Console.WriteLine("Listando as faturas: ");

    foreach (var item in documentos)
    {
       if (item is Fatura)
       {
        item.Imprimir();
       }
    }
}

void ListarContratos()
{
     System.Console.WriteLine("Listando os Contratos: ");

    foreach (var item in documentos)
    {
       if (item is Contrato)
       {
        item.Imprimir();
       }
    }
}

void ListarRelatorios()
{
     System.Console.WriteLine("Listando os Relatorios: ");

    foreach (var item in documentos)
    {
       if (item is Relatorio)
       {
        item.Imprimir();
       }
    }
}