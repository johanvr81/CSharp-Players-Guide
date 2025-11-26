using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public static class FightRenderer
    {
        public static void Render(Fight battle, Character activeCharacter)
        {
            ColoredConsole.WriteLine($"===================================================== BATTLE ====================================================", ConsoleColor.White);

            foreach (Character character in battle.Heroes.Characters)
            {
                ConsoleColor color = character == activeCharacter ? ConsoleColor.Yellow : ConsoleColor.Gray;
                ColoredConsole.WriteLine($"{character.Name,-45} ({character.HP,3}/{character.MaxHP,-3})", color);
            }

            ColoredConsole.WriteLine("------------------------------------------------------ VS -------------------------------------------------------", ConsoleColor.White);

            foreach (Character character in battle.Monsters.Characters)
            {
                ConsoleColor color = character == activeCharacter ? ConsoleColor.Yellow : ConsoleColor.Gray;
                ColoredConsole.WriteLine($"                                                          {character.Name,45} ({character.HP,3}/{character.MaxHP,-3})", color);
            }

            ColoredConsole.WriteLine("=================================================================================================================", ConsoleColor.White);
        }
    }
}
