using The_Old_Robot;

Console.Title = "The Old Robot";

Robot robot = new Robot();

while (true)
{
    string? input = Console.ReadLine();

    if (input == "stop") break;

    robot.Commands.Add(input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
    });
}

Console.WriteLine();

robot.Run();