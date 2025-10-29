using The_Sieve;

Console.Title = "The Sieve";

Console.Write("Which filter do you want to use? (1=Even, 2=Positive, 3=MultipleOfTen) ");
int choice = Convert.ToInt32(Console.ReadLine());

Sieve sieve = choice switch
{
    1 => new Sieve(IsEven),
    2 => new Sieve(IsPositive),
    3 => new Sieve(IsMultipleOfTen)
};

while (true)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string goodOrEvil = sieve.IsGood(number) ? "good" : "evil";
    Console.WriteLine($"That number is {goodOrEvil}.");
}

bool IsEven(int number) => number % 2 == 0;
bool IsPositive(int number) => number > 0;
bool IsMultipleOfTen(int number) => number % 10 == 0;


/*
Instead of passing methods to the Sieve class, you could use inheritance—create an abstract Sieve base class (or interface) with implementations like EvenSieve, PositiveSieve, and MultipleOfTenSieve.

This approach works fine, but in this case, delegates are simpler and clearer. The delegate version is shorter and keeps the core logic more visible, while the inheritance version adds unnecessary structure.
*/