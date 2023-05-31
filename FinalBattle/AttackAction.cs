using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class AttackAction : IAction
{
    public void Run(ICharacter attacker, Party party)
    { 
        Console.WriteLine($"{attacker.Name} used {attacker.Attack.Name.ToUpper()} on {party.Characters.First().Name}");
    }
}
