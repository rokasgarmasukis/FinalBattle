using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class Skeleton : ICharacter
{
    public string Name { get; } = "SKELETON";
    public IAttack Attack { get; } = new BoneCrunch();
}

internal class BoneCrunch : IAttack
{
    public string Name { get; } = "bone crunch";
}
