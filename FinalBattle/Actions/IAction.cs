using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalBattle.Characters;

namespace FinalBattle.Actions;

internal interface IAction
{
    void Run(ICharacter character, Party party);
}
