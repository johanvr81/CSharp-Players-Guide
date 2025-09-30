// See https://aka.ms/new-console-template for more information
Console.Title = "The Laws of Freach";

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue; // Start higher than anything in the array. 

foreach (int item in array)
{
    if (item < currentMinimum)
        currentMinimum = item;
}

Console.WriteLine(currentMinimum);


int total = 0;

foreach (int value in array)
    total += value;

float average = (float)total / array.Length;

Console.WriteLine(average);
