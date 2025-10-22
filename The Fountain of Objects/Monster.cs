using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    public abstract class Monster
    {
        public Location Location { get; set; }

        public bool IsAlive { get; set; } = true;

        public Monster(Location start) => Location = start;

        public abstract void Activate(FountainOfObjectsGame game);
    }

    public class Amarok : Monster
    {
        public Amarok(Location start) : base(start) { }

        public override void Activate(FountainOfObjectsGame game) => game.Player.Kill("You have encountered an amarok and have died.");
    }


}
