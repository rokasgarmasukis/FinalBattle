﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal interface IAttack
{
    string Name { get; }
    int Damage { get; }
}
