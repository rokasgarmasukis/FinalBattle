using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle;

internal class Party
{
    public string Name { get; } = string.Empty;
    public List<ICharacter> Characters { get; } = new List<ICharacter>();
}
