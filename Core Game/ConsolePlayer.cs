using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class ConsolePlayer : IPlayer
    {
        public IAction ChooseAction(Fight battle, Character character)
        {
            List<MenuChoice> menuChoices = CreateMenuOptions(battle, character);

            for (int index = 0; index < menuChoices.Count; index++)
                ColoredConsole.WriteLine($"{index + 1} - {menuChoices[index].Description}", menuChoices[index].Enabled ? ConsoleColor.Gray : ConsoleColor.DarkGray);

            string choice = ColoredConsole.Prompt("What do you want to do?");
            int menuIndex = Convert.ToInt32(choice) - 1;

            if (menuChoices[menuIndex].Enabled) return menuChoices[menuIndex].Action!; // Checking if it is enabled is as good as a null check.

            return new DoNothingAction();
        }

        private List<MenuChoice> CreateMenuOptions(Fight battle, Character character)
        {
            Party currentParty = battle.GetPartyFor(character);
            Party otherParty = battle.GetEnemyPartyFor(character);

            List<MenuChoice> menuChoices = new List<MenuChoice>();

            if (otherParty.Characters.Count > 0)
                menuChoices.Add(new MenuChoice($"Standard Attack ({character.StandardAttack.Name})", new AttackAction(character.StandardAttack, otherParty.Characters[0])));
            else
                menuChoices.Add(new MenuChoice($"Standard Attack ({character.StandardAttack.Name})", null));


            menuChoices.Add(new MenuChoice("Do Nothing", new DoNothingAction()));

            return menuChoices;
        }
    }
}
