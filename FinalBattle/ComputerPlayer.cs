using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class ComputerPlayer : IPlayer
{

    public Party Party { get; }

    public ComputerPlayer(Party p)
    {
        Party = p;
    }

    public IAction ChooseAction()
    {
        return new AttackAction();
    }
}
