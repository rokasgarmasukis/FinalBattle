using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle.Characters;

internal class Skeleton : ICharacter
{
    public string Name { get; } = "SKELETON";
    public IAttack Attack { get; } = new BoneCrunch();
    public int HP { get; set; } = 5;

    public int HPMax => 5;
}

internal class BoneCrunch : IAttack
{
    public string Name { get; } = "bone crunch";

    public int Damage
    {
        get
        {
            Random random = new Random();
            return random.Next(2);
        }
    }
}
