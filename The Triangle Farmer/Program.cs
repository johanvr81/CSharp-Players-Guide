// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let's calculate the are of a Triangle!");

Console.WriteLine("Enter the Base:");
var basesize = Console.ReadLine();
Console.WriteLine("Enter the Height;");
var height = Console.ReadLine();

double area = (Convert.ToDouble(basesize) * Convert.ToDouble(height)) / 2;

Console.WriteLine("The Area is: "+ area +"m2");


