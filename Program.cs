// See https://aka.ms/new-console-template for more information
using System.Threading;

Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("|----------(MENU)----------|");
    Console.WriteLine("| 1 - Configurar e iniciar |");
    Console.WriteLine("| 2 - Sair                 |");
    Console.WriteLine("|__________________________|");

    short res = short.Parse(Console.ReadLine());
    switch (res)
    {
        case 1: Start(); break;
        case 2: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Start()
{
    Console.Clear();
    int currentTime = 0;
    Console.WriteLine("Vamos contar até que número?");
    int time = int.Parse(Console.ReadLine());

    while(currentTime != time) 
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(@"   |--------------------------|");
        Console.WriteLine($@"   |------ Contando... {currentTime} -----|");
        Console.WriteLine(@"   |--------------------------|");
        Thread.Sleep(1000); // Deixamos o processador "pausado" por 1000 milisegundos.
    }
    Console.Clear();
    Console.WriteLine(@"
    |--------------------------|
    |Feito! O tempo acabou! :) |
    |--------------------------|
    ");
        Thread.Sleep(22000);
    Menu();
}
