﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal interface IPlayer
{
    Party Party { get; }
    IAction ChooseAction();

}
