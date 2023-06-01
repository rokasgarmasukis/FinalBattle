using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle.Characters;

internal class TrueProgrammer : ICharacter
{
    public string Name { get; init; } = "TRUE PROGRAMMER";
    public int HP { get; set; } = 25;
    public IAttack Attack { get; } = new Punch();

    public int HPMax => 25;
}

internal class Punch : IAttack
{
    public string Name { get; } = "punch";

    public int Damage { get; } = 1;
}
