using FinalBattle;

Console.Title = "Final Battle";

Party heroes = new ();
heroes.Characters.Add(new Skeleton());

Party monsters = new();
monsters.Characters.Add(new Skeleton());


while(true)
{
    foreach(var hero in heroes.Characters)
    {
        Console.WriteLine($"It is {hero.Name}'s turn...");
        hero.Execute(new DoNothingAction());
    }
    Console.WriteLine("...");
    Thread.Sleep(1000);
    foreach (var monster in monsters.Characters)
    {
        Console.WriteLine($"It is {monster.Name}'s turn...");
        monster.Execute(new DoNothingAction());
    }
    Console.WriteLine("...");
    Thread.Sleep(1000);

}

