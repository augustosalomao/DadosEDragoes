
string boasVindas = "BEM VINDOS AO DADOS E DRAGÕES";

System.Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░░██████╗  ███████╗  ██████╗░██████╗░░█████╗░░██████╗░░█████╗░███████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔════╝  ██╔══██╗██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔════╝██╔════╝
██║░░██║███████║██║░░██║██║░░██║╚█████╗░  █████╗░░  ██║░░██║██████╔╝███████║██║░░██╗░██║░░██║█████╗░░╚█████╗░
██║░░██║██╔══██║██║░░██║██║░░██║░╚═══██╗  ██╔══╝░░  ██║░░██║██╔══██╗██╔══██║██║░░╚██╗██║░░██║██╔══╝░░░╚═══██╗
██████╔╝██║░░██║██████╔╝╚█████╔╝██████╔╝  ███████╗  ██████╔╝██║░░██║██║░░██║╚██████╔╝╚█████╔╝███████╗██████╔╝
╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═════╝░  ╚══════╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░░╚════╝░╚══════╝╚═════╝░");

void ExibirMensagemDeBoasVindas()
{
    System.Console.WriteLine(boasVindas);
}

//List<string> Rpg = new List<string> {"D&D", "Tormenta20", "Ordem Paranormal"};

Dictionary<string, List<int>> registroDeRPGs = new Dictionary<string, List<int>>();
registroDeRPGs.Add("Tormenta20", new List<int> { 10, 5, 7 });
registroDeRPGs.Add("Ordem Paranormal", new List<int>());


void RegistrarRPG()
{
    Console.Clear();
    Console.WriteLine("Qual o nome do RPG para registro? ");
    string rpgEscolhido = Console.ReadLine()!;
    if (registroDeRPGs.ContainsKey(rpgEscolhido))
    {
        Console.WriteLine($"O RPG {rpgEscolhido} já está registrado");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        registroDeRPGs.Add(rpgEscolhido, new List<int>());
        Console.WriteLine($"O RPG {rpgEscolhido} foi registrado com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ListarRPG()
{
    System.Console.WriteLine("Lista de RPGs adicionados: ");
    foreach (KeyValuePair<string, List<int>> par in registroDeRPGs)
    {
        string notas = string.Join(", ", par.Value);
        System.Console.WriteLine($"RPG: {par.Key} Notas: {notas}");

    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu(); 
}

void AvaliarRPG()
{
    System.Console.WriteLine("Escolha qual RPG você quer avaliar: ");
    string rpg = Console.ReadLine()!;
    

    if (registroDeRPGs.ContainsKey(rpg))
    {
        Console.Write($"Qual a nota que o seu RPG {rpg} merece: ");
        int notaRPG = int.Parse(Console.ReadLine()!);
        registroDeRPGs[rpg].Add(notaRPG);
        System.Console.WriteLine($"\n A nota {notaRPG} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        System.Console.WriteLine($"O RPG {rpg} não foi encontrado");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();    
        ExibirOpcoesDoMenu();
    }

    
}

void MostrarMediaRPG()
{
    System.Console.WriteLine("Escolha qual RPG você ver a media de avaliações: ");
    string rpg = Console.ReadLine()!;
    if (registroDeRPGs.ContainsKey(rpg))
    {   

        if (registroDeRPGs[rpg].Count > 0) {
            double media = registroDeRPGs[rpg].Average();
            System.Console.WriteLine($"A media de notas de {rpg} é de {media:F1}");
            Thread.Sleep(2000);
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    } else
    {
        System.Console.WriteLine($"O RPG {rpg} não foi encontrado");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();    
        ExibirOpcoesDoMenu();
    }
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar seu rpg");
    Console.WriteLine("Digite 2 para mostrar todos os rpgs");
    Console.WriteLine("Digite 3 para avaliar um rpg");
    Console.WriteLine("Digite 4 para exibir a media de um rpg");
    Console.WriteLine("Digite -1 para sair");

    System.Console.WriteLine("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1:
            RegistrarRPG();
            break;
        case 2:
            ListarRPG();
            break;
        case 3:
            AvaliarRPG();
            break;
        case 4:
            MostrarMediaRPG();
            break;
        case -1:
            Console.WriteLine("Você escolheu a opcao " + opcao + "Saindooooooo");
            break;
        default:
            System.Console.WriteLine("Error, tente novamente" + opcao);
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

