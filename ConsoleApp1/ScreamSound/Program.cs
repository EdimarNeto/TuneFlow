// Backend SoundScream

List<string> listaDeBandas = new List<string>{"Calypson", "Mamonas Assasinas", "U2"};

string nomeApp = "𝙏𝙪𝙣𝙚𝙁𝙡𝙤𝙬";
string msgBoasVindas = $"{nomeApp} \n Bem vindo! ♫ ♪ ♫ (¯`◕‿◕´¯)ღ";

void  msgInicial()
{
    Console.WriteLine(msgBoasVindas);
    Console.WriteLine(" ");
}

void exibirMenu()
{
    Console.WriteLine("Escolha sua opção abaixo:");
    Console.WriteLine("[1] Registrar Bandas");
    Console.WriteLine("[2] Exibir Bandas");
    Console.WriteLine("[3] Avaliar Bandas");
    Console.WriteLine("[4] Remover Bandas");
    Console.WriteLine("[5] Exibir Média");
    Console.WriteLine("[6] Sair");
    
    Console.Write("\nSua escolha >> ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ExibirBandas();
            break;
        case 3:Console.WriteLine("Avalie sua Banda favorita");
            break;
        case 4:Console.WriteLine("Remover Banda");
            break;
        case 5:Console.WriteLine("Avaliações do Publico");
            break;
        case 6:Console.WriteLine("Programa finalizado. Obrigado por vir!");
            break;
        default:Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("♫ ♪ ♫  Registre uma nova Banda ♫ ♪ ♫ (¯`◕‿◕´¯)ღ\n");
    Console.Write("Digite o nome do banda: ");
    string nomeBanda = Console.ReadLine();
    listaDeBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi adicionada com Sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    msgInicial();
    exibirMenu();
}

void ExibirBandas()
{
    Console.Clear();
    Console.WriteLine("♫ ♪ ♫  Nossas Bandas  ♫ ♪ ♫ (¯`◕‿◕´¯)ღ\n");
    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($". {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    msgInicial();
    exibirMenu();
}

msgInicial();
exibirMenu();
