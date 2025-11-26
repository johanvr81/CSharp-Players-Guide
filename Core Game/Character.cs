using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    /// <summary>
    /// Defines what all characters in the game have in common.
    /// </summary>
    public abstract class Character
    {
        public abstract string Name { get; }

        public abstract IAttack StandardAttack { get; }

        public IGear? EquippedGear { get; set; }
        public IAttackModifier? DefensiveModifier { get; set; }

        private int _hp;

        public int HP
        {
            get => _hp;
            set => _hp = Math.Clamp(value, 0, MaxHP);
        }

        public int MaxHP { get; }

        public bool IsAlive => HP > 0;
        public Character(int hp)
        {
            MaxHP = hp;
            HP = hp;
        }
    }
}
