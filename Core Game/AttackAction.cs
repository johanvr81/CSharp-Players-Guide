using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class AttackAction : IAction
    {
        private static readonly Random _random = new Random();

        private readonly IAttack _attack;

        private readonly Character _target;

        public AttackAction(IAttack attack, Character target)
        {
            _attack = attack;
            _target = target;
        }

        public void Run(Fight battle, Character actor)
        {
            Console.WriteLine($"{actor.Name} used {_attack.Name} on {_target.Name}.");

            AttackData data = _attack.Create();

            if (_random.NextDouble() > data.ProbabilityOfHitting)
            {
                ColoredConsole.WriteLine($"{actor.Name} MISSED!", ConsoleColor.DarkRed);
                return;
            }

            if (_target.DefensiveModifier != null)
                data = _target.DefensiveModifier.Modify(data);

            _target.HP -= data.Damage;

            Console.WriteLine($"{_attack.Name} dealt {data.Damage} damage to {_target.Name}.");
            Console.WriteLine($"{_target.Name} is now at {_target.HP}/{_target.MaxHP} HP.");

            if (!_target.IsAlive)
            {
                battle.GetPartyFor(_target).Characters.Remove(_target);
                Console.WriteLine($"{_target.Name} was defeated!");
                if (_target.EquippedGear != null)
                {
                    IGear acquiredGear = _target.EquippedGear;
                    battle.GetPartyFor(actor).Gear.Add(acquiredGear);
                    ColoredConsole.WriteLine($"{actor.Name}'s party has recovered {_target.Name}'s {acquiredGear.Name}.", ConsoleColor.Magenta);
                }
            }
        }
    }

}
