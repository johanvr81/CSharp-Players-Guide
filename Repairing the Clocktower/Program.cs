// See https://aka.ms/new-console-template for more information

Console.Title = "Repairing the Clocktower";

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");
