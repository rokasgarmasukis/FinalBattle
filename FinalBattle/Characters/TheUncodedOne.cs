using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle.Characters;

internal class TheUncodedOne : ICharacter
{
    public string Name => "The Uncoded One";

    public int HP { get; set; } = 15;

    public int HPMax => 15;

    public IAttack Attack => new Unraveling();
}

internal class Unraveling : IAttack
{
    public string Name => "Unraveling";

    public int Damage
    {
        get
        {
            Random random = new Random();
            return random.Next(3);
        }
    }
}
