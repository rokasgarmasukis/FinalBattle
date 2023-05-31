using FinalBattle;

Console.Title = "Final Battle";

Party heroes = new ();
Console.WriteLine("What is your name, my hero?");
string? name = Console.ReadLine();
heroes.Characters.Add(new TrueProgrammer() { Name = name?.ToUpper() ?? "TRUE PROGRAMMER"});
HumanPlayer humanPlayer = new HumanPlayer(heroes);

Party monsters = new();
monsters.Characters.Add(new Skeleton());
ComputerPlayer computerPlayer = new ComputerPlayer(monsters);


while(true)
{
    foreach(var hero in heroes.Characters)
    {
        Console.WriteLine($"It is {hero.Name}'s turn...");
        IAction action = humanPlayer.ChooseAction();
        Thread.Sleep(1000);
        action.Run(hero, monsters);
        Console.WriteLine();

    }
    foreach (var monster in monsters.Characters)
    {
        Console.WriteLine($"It is {monster.Name}'s turn...");
        IAction action = computerPlayer.ChooseAction();
        Thread.Sleep(1000);
        action.Run(monster, heroes);
        Console.WriteLine();
    }

}

