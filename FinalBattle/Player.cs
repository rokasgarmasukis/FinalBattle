using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class Player : IPlayer
{
    public Party Party { get; init; }

    public IAction ChooseAction()
    {
        int choice;
        while (true)
        {
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("1 - Do Nothing");
            string input = Console.ReadLine();
            bool goodChoice = int.TryParse(input, out choice);
            if (!goodChoice)
            {
                Console.WriteLine("Wrong input. Try again.");
                continue;
            }
            if (choice < 1 || choice > 2)
            {
                Console.WriteLine("No such action exists. Try again.");
                continue;
            }
            break;
        }
        IAction action = choice switch
        {
            1 => new DoNothingAction(),
        };
        return action;
    }
}
