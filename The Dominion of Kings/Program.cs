// See https://aka.ms/new-console-template for more information
Console.WriteLine("The Dominion of Kings");

Console.WriteLine("Enter the number of Provinces:");
int provinces = Convert.ToInt32(Console.ReadLine()) * 6;

Console.WriteLine("Enter the number of Duchies:");
int duchies = Convert.ToInt32(Console.ReadLine()) * 3;

Console.WriteLine("Enter the number of Estates:");
int estates = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total point(s): "+ (provinces + duchies + estates));