using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Unraveling : IAttack
    {
        private static readonly Random _random = new Random();
        public string Name => "UNRAVELING";
        public AttackData Create() => new AttackData(_random.Next(3));
    }
}
