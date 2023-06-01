using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalBattle.Characters;

namespace FinalBattle;

internal class Party
{
    public string Name { get; } = string.Empty;
    public List<ICharacter> Characters { get; set; } = new List<ICharacter>();

    public void CheckAndRemoveDeadCharacters()
    {
        foreach (var character in Characters)
        {
            if (character.HP == 0)
            {
                Console.WriteLine($"{character.Name.ToUpper()} has been defeated!");
                Console.WriteLine();
            }
        }
        Characters = Characters.Where(x => x.HP != 0).ToList();
    }
}
