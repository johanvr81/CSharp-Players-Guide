using Robotic_Interface;

Console.Title = "The Old Robot";

Robot robot = new Robot();

for (int index = 0; index < robot.Commands.Length; index++)
{
    string? input = Console.ReadLine();
    robot.Commands[index] = input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
    };
}

Console.WriteLine();

robot.Run();
