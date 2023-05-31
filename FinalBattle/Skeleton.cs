using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class Skeleton : ICharacter
{
    public string Name { get; } = "SKELETON";

    public void Execute(IAction action) {
        action.Run(Name);
    }
}
