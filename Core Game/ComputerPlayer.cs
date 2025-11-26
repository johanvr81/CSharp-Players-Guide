using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class ComputerPlayer : IPlayer
    {
        private static Random _random = new Random();

        public IAction ChooseAction(Fight battle, Character character)
        {
            Thread.Sleep(500);

            bool hasPotion = battle.GetPartyFor(character).Items.Count > 0; 
            bool isHPUnderThreshold = character.HP / (float)character.MaxHP < 0.5;
            if (hasPotion && isHPUnderThreshold && _random.NextDouble() < 0.25)
                return new UseItemAction(battle.GetPartyFor(character).Items[0]);

            if (character.EquippedGear == null && battle.GetPartyFor(character).Gear.Count > 0 && _random.NextDouble() < 0.5)
                return new EquipGearAction(battle.GetPartyFor(character).Gear[0]);

            List<Character> potentialTargets = battle.GetEnemyPartyFor(character).Characters;
            if (potentialTargets.Count > 0)
            {
                if (character.EquippedGear != null) return new AttackAction(character.EquippedGear.Attack, battle.GetEnemyPartyFor(character).Characters[0]);
                else return new AttackAction(character.StandardAttack, battle.GetEnemyPartyFor(character).Characters[0]);
            }

            return new DoNothingAction();
        }
    }

}
