using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class VinFletcher : Character
    {
        public override string Name => "VIN FLETCHER";
        public override IAttack StandardAttack { get; } = new Punch();
        public VinFletcher() : base(15) => EquippedGear = new VinsBow();
    }

    public class VinsBow : IGear
    {
        public string Name => "VIN'S BOW";
        public IAttack Attack => new QuickShot();
    }

    public class QuickShot : IAttack
    {
        public string Name => "QUICK SHOT";
        public AttackData Create() => new AttackData(3, 0.5);
    }
}
