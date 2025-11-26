using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class DoNothingAction : IAction
    {
        public void Run(Fight fight, Character actor) => Console.WriteLine($"{actor.Name} did NOTHING.");
    }
}
