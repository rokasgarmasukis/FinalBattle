using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalBattle.Characters;

namespace FinalBattle.Actions;

internal class AttackAction : IAction
{
    public void Run(ICharacter attacker, Party party)
    {
        int damage = attacker.Attack.Damage;
        string attackName = attacker.Attack.Name;
        ICharacter defender = party.Characters.First();

        defender.HP = damage < defender.HP ? defender.HP - damage : 0;
        Console.WriteLine($"{attacker.Name.ToUpper()} used {attackName.ToUpper()} on {defender.Name.ToUpper()}.");
        Console.WriteLine($"{attackName.ToUpper()} dealt {damage} damage to {defender.Name.ToUpper()}.");
        Console.WriteLine($"{defender.Name.ToUpper()} is now at {defender.HP}/{defender.HPMax} HP.");



    }
}
