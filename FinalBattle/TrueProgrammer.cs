using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class TrueProgrammer : ICharacter
{
    public string Name { get; init; } = "TRUE PROGRAMMER";
    public IAttack Attack { get; } = new Punch();

}

internal class Punch : IAttack
{
    public string Name { get; } = "punch";
}
