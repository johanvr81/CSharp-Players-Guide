using Helpers;

Console.Title = "Colored Console";


string? name = ColoredConsole.Prompt("What is your name?");
ColoredConsole.WriteLine("Hello " + name, ConsoleColor.Green);