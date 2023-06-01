using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalBattle.Actions;

namespace FinalBattle;

internal class Battle
{
    public Battle(IPlayer humanPlayer, IPlayer computerPlayer)
    {
        HumanPlayer = humanPlayer;
        ComputerPlayer = computerPlayer;
    }

    public IPlayer HumanPlayer { get; }
    public IPlayer ComputerPlayer { get; }

    internal void Run()
    {
        while (true)
        {
            RunRound(HumanPlayer, ComputerPlayer);
            if (HasAPartyBeenDefeated()) break;
            RunRound(ComputerPlayer, HumanPlayer);
            if (HasAPartyBeenDefeated()) break;
        }
        StateBattleResult();
    }

    private void RunRound(IPlayer attackingPlayer, IPlayer defendingPlayer)
    {
        foreach (var attacker in attackingPlayer.Party.Characters)
        {
            Console.WriteLine($"It is {attacker.Name}'s turn...");
            IAction action = attackingPlayer.ChooseAction();
            action.Run(attacker, defendingPlayer.Party);
            Thread.Sleep(500);
            Console.WriteLine();
            defendingPlayer.Party.CheckAndRemoveDeadCharacters();
        }
    }

    private bool HasAPartyBeenDefeated()
    {
        if (HumanPlayer.Party.Characters.Count == 0 || ComputerPlayer.Party.Characters.Count == 0) return true;
        return false;
    }

    private void StateBattleResult()
    {
        IPlayer winner;
        if (HumanPlayer.Party.Characters.Count > 0) { winner = HumanPlayer; }
        else winner = ComputerPlayer;

        if (winner == HumanPlayer)
        {
            Console.WriteLine("Humans have won this battle!");
        }
        else
        {
            Console.WriteLine("The forces of the Uncoded One have prevailed over humans...");
        }
    }
}
