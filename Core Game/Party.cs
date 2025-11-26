using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Party
    {
        public IPlayer Player { get; }
        public List<Character> Characters { get; } = new List<Character>();
        public List<IItem> Items { get; } = new List<IItem>();
        public List<IGear> Gear { get; } = new List<IGear>();
        public Party(IPlayer player)
        {
            Player = player;
        }
    }

}
