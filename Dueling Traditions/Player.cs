using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelingTraditions
{
    public class Player
    {
        public Location Location { get; set; }

        public bool IsAlive { get; private set; } = true;

        public string CauseOfDeath { get; private set; } = "";

        public Player(Location start) => Location = start;

        public void Kill(string cause)
        {
            IsAlive = false;
            CauseOfDeath = cause;
        }
    }
}
