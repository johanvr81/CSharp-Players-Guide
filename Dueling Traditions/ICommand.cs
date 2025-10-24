using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelingTraditions
{
   public interface ICommand
    {
        void Execute(FountainOfObjectsGame game);
    }

    public class HelpCommand : ICommand
    {
        public void Execute(FountainOfObjectsGame game)
        {
            ConsoleHelper.WriteLine("help", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("    Displays this help information.", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("enable fountain", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("    Turns on the Fountain of Objects if you are in the fountain room, or does nothing if you are not.", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("move north", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("    Moves to the room directly north of the current room, as long as there are no walls.", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("move south", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("    Moves to the room directly south of the current room, as long as there are no walls.", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("move east", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("    Moves to the room directly east of the current room, as long as there are no walls.", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("move west", ConsoleColor.Gray);
            ConsoleHelper.WriteLine("    Moves to the room directly west of the current room, as long as there are no walls.", ConsoleColor.Gray);
        }
    }
}
