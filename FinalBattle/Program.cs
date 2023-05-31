using FinalBattle;

Console.Title = "Final Battle";

Party heroes = new ();
Console.WriteLine("What is your name, my hero?");
string name = Console.ReadLine();
heroes.Characters.Add(new TrueProgrammer() { Name = name ?? "True Programmer"});
HumanPlayer humanPlayer = new HumanPlayer() { Party = heroes };

Party monsters = new();
monsters.Characters.Add(new Skeleton());
ComputerPlayer computerPlayer = new ComputerPlayer() { Party = monsters };


while(true)
{
    foreach(var hero in heroes.Characters)
    {
        Console.WriteLine($"It is {hero.Name}'s turn...");
        IAction action = humanPlayer.ChooseAction();
        action.Run(hero);
    }
    foreach (var monster in monsters.Characters)
    {
        Console.WriteLine($"It is {monster.Name}'s turn...");
        IAction action = computerPlayer.ChooseAction();
        action.Run(monster);
    }

}

