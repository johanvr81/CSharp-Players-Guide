// See https://aka.ms/new-console-template for more information
Console.Title = "The Magic Cannon";

int totalshots = 100;

for (int currentshot = 1; currentshot <= totalshots; currentshot++)
{
    if (currentshot % 5 == 0 && currentshot % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{currentshot}: Electric and Fire");
    }
    else if (currentshot % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{currentshot}: Electric");
    }
    else if (currentshot % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{currentshot}: Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{currentshot}: Normal");
    }
}
