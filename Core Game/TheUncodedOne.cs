using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class TheUncodedOne : Character
    {
        public override string Name => "THE UNCODED ONE";
        public TheUncodedOne() : base(15) { }
        public override IAttack StandardAttack { get; } = new Unraveling();
    }
}
