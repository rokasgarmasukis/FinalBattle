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

Battle battle = new Battle(humanPlayer, computerPlayer);
battle.Run();



