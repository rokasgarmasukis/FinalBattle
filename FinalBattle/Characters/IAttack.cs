﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle.Characters;

internal interface IAttack
{
    string Name { get; }
    int Damage { get; }
}
