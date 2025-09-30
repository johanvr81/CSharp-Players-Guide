// See https://aka.ms/new-console-template for more information
Console.Title = "The Replicator of D’To";

int[] array1 = new int[5];

for (int item = 0; item < 5; item++)
{
    Console.Write("Enter a number: ");
    array1[item] = Convert.ToInt32(Console.ReadLine());
}

int[] array2 = new int[5];

for (int index = 0; index < 5; index++)
    array2[index] = array1[index];

for (int index = 0; index < 5; index++)
    Console.WriteLine($"{array1[index]} and {array2[index]}");
