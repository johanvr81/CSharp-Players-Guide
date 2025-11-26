using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Fight
    {
        public Party Heroes { get; }
        public Party Monsters { get; }

        public Fight(Party heroes, Party monsters)
        {
            Heroes = heroes;
            Monsters = monsters;
        }

        public void Run()
        {
            while (!IsOver)
            {
                foreach (Party party in new[] { Heroes, Monsters })
                {
                    foreach (Character character in party.Characters)
                    {
                        Console.WriteLine(); 

                        FightRenderer.Render(this, character);

                        Console.WriteLine($"{character.Name} is taking a turn...");

                        party.Player.ChooseAction(this, character).Run(this, character);

                        if (IsOver) break; 
                    }

                    if (IsOver) break; 
                }
            }

            if (Heroes.Characters.Count > 0)
            {
                ColoredConsole.WriteLine("The HEROES have defeated the MONSTERS and looted their inventory.", ConsoleColor.Magenta);
                TransferInventory();
            }
        }

        private void TransferInventory()
        {
            foreach (IGear gear in Monsters.Gear)
            {
                ColoredConsole.WriteLine($"The HEROES have acquired {gear.Name}.", ConsoleColor.DarkMagenta);
                Heroes.Gear.Add(gear);
            }

            foreach (IItem item in Monsters.Items)
            {
                ColoredConsole.WriteLine($"The HEROES have acquired {item.Name}.", ConsoleColor.DarkMagenta);
                Heroes.Items.Add(item);
            }
        }

        public bool IsOver => Heroes.Characters.Count == 0 || Monsters.Characters.Count == 0;

        public Party GetEnemyPartyFor(Character character) => Heroes.Characters.Contains(character) ? Monsters : Heroes;
        public Party GetPartyFor(Character character) => Heroes.Characters.Contains(character) ? Heroes : Monsters;
    }
}
