using DuelingTraditions;

Console.Title = "Dueling Traditions";

FountainOfObjectsGame game = CreateSmallGame();

DisplayIntro();

game.Run();

void DisplayIntro()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("You enter the Cavern of Objects, a maze filled with dangerous pits, in search");
    Console.WriteLine("of the Fountain of Objects.");
    Console.WriteLine("Light is visible only in the entrance, and no other light is seen anywhere in the caverns.");
    Console.WriteLine("You must navigate the Caverns with your other senses.");
    Console.WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
}

FountainOfObjectsGame CreateSmallGame()
{
    Map map = new Map(4, 4);
    Location start = new Location(0, 0);
    map.SetRoomTypeAtLocation(start, RoomType.Entrance);
    map.SetRoomTypeAtLocation(new Location(0, 2), RoomType.Fountain);

    Monster[] monsters = new Monster[]
    {
        new Amarok(new Location(0, 3))
    };

    return new FountainOfObjectsGame(map, new Player(start), monsters);
}