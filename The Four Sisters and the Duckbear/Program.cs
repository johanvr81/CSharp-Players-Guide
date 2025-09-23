// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let's calculate how many eggs the each of the four sisters get!");

Console.WriteLine("How many eggs was laid today?");
var eggs = Console.ReadLine();
int sistereggs = Convert.ToInt32(eggs) / 4;
int duckbear = Convert.ToInt32(eggs) % 4;

Console.WriteLine("Each sister gets: " + sistereggs + " and the duckbear: "+ duckbear);