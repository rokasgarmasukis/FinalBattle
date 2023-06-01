using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal interface ICharacter
{
    string Name { get; }
    int HP { get; set; }
    int HPMax { get; }
    IAttack Attack { get; }

}
