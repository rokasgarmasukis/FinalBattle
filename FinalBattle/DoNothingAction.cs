using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle
{
    internal class DoNothingAction : IAction
    {
        public void Run(ICharacter character, Party _)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{character.Name} did NOTHING.");
        }
    }
}
