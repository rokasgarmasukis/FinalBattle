using FinalBattle.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class Game
{
    IPlayer HumanPlayer { get; set; }
    IPlayer ComputerPlayer { get; set; }

    public Game()
    {
        Party heroes = new();
        Console.WriteLine("What is your name, my hero?");
        string? name = Console.ReadLine();
        heroes.Characters.Add(new TrueProgrammer() { Name = name?.ToUpper() ?? "TRUE PROGRAMMER" });
        HumanPlayer = new HumanPlayer(heroes);

        Party monsters = new();
        monsters.Characters.Add(new Skeleton());
        ComputerPlayer = new ComputerPlayer(monsters);
    }

    public void Run()
    {
        Battle firstBattle = new Battle(HumanPlayer, ComputerPlayer);
        BattleBeginsMessage("First battle");
        firstBattle.Run();
        if (HasGameEnded())
        {
            Console.WriteLine("Humans have LOST. Try again.");
            return;
        }

        ComputerPlayer.Party.Characters.AddRange(new List<ICharacter> { new Skeleton(), new Skeleton() });
        Battle secondBattle = new Battle(HumanPlayer, ComputerPlayer);
        BattleBeginsMessage("Second battle");
        secondBattle.Run();
        if (HasGameEnded())
        {
            Console.WriteLine("Humans have LOST. Try again.");
            return;
        }

        ComputerPlayer.Party.Characters.Add(new TheUncodedOne());
        Battle finalBattle = new Battle(HumanPlayer, ComputerPlayer);
        BattleBeginsMessage("Final battle");
        finalBattle.Run();
        if (HasGameEnded())
        {
            Console.WriteLine("Humans have LOST. Try again.");
        } else
        {
            Console.WriteLine("VICTORY! Humans have prevailed!");
        }
    }

    private bool HasGameEnded()
    {
        if (HumanPlayer.Party.Characters.Count == 0) return true;
        else return false;
    }

    private void BattleBeginsMessage(string battle)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"{battle} begins");
        Console.WriteLine("--------------------------------------");
    }
}
