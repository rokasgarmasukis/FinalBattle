using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBattle
{
    internal class DoNothingAction : IAction
    {
        public void Run(string name)
        {
            Console.WriteLine($"{name} did NOTHING.");
        }
    }
}
