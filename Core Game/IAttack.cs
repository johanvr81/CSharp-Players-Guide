using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public interface IAttack
    {
        string Name { get; }
        AttackData Create();
    }

    public record AttackData(int Damage, double ProbabilityOfHitting = 1.0, DamageType Type = DamageType.Normal);

    public enum DamageType { Normal, Decoding }
}
