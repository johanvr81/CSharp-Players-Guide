// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.Title = "The Prototype";

Console.WriteLine("User 1, enter a number between 0 and 100:");
int userOneNumber = Convert.ToInt16(Console.ReadLine());
Console.Clear();

int userTwoNumber = 0;

Console.WriteLine("User 2, guess the number.");

while (userTwoNumber != userOneNumber)
{
    Console.Write("What is your next guess ?");
    userTwoNumber = Convert.ToInt16(Console.ReadLine());

    if (userTwoNumber > userOneNumber)
    {
        Console.WriteLine($"{userTwoNumber} is to high.");
    }

    if (userTwoNumber < userOneNumber)
    {
        Console.WriteLine($"{userTwoNumber} is to low.");
    } 
}

Console.WriteLine("You guessed the number!");


