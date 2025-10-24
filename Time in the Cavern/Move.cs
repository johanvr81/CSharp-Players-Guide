using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    public class MoveCommand : ICommand
    {
        // The direction to move.
        public Direction Direction { get; }

        // Creates a new movement command with a specific direction to move.
        public MoveCommand(Direction direction)
        {
            Direction = direction;
        }

        // Causes the player's position to be updated with a new position, shifted in the intended direction,
        // but only if the destination stays on the map. Otherwise, nothing happens.
        public void Execute(FountainOfObjectsGame game)
        {
            Location currentLocation = game.Player.Location;
            Location newLocation = Direction switch
            {
                Direction.North => new Location(currentLocation.Row - 1, currentLocation.Column),
                Direction.South => new Location(currentLocation.Row + 1, currentLocation.Column),
                Direction.West => new Location(currentLocation.Row, currentLocation.Column - 1),
                Direction.East => new Location(currentLocation.Row, currentLocation.Column + 1)
            };

            if (game.Map.IsOnMap(newLocation))
                game.Player.Location = newLocation;
            else
                ConsoleHelper.WriteLine("There is a wall there.", ConsoleColor.Red);
        }
    }

    public class EnableFountainCommand : ICommand
    {
        public void Execute(FountainOfObjectsGame game)
        {
            if (game.Map.GetRoomTypeAtLocation(game.Player.Location) == RoomType.Fountain) game.IsFountainOn = true;
            else ConsoleHelper.WriteLine("The fountain is not in this room. There was no effect.", ConsoleColor.Red);
        }
    }
    public enum Direction { North, South, West, East }

    public enum RoomType { Normal, Entrance, Fountain, OffTheMap }

}
