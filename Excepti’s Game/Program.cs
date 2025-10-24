Console.Title = "Excepti’s Game";

try
{
    int targetNumber = new Random().Next(10);
    List<int> previousGuesses = new List<int>();

    while (true)
    {
        int number;
        bool isprevious;
        do
        {
            Console.Write("Pick a number between 0 and 9 (inclusive): ");
            number = Convert.ToInt32(Console.ReadLine());
            isprevious = previousGuesses.Contains(number);
            if (isprevious) Console.WriteLine("That number has been guessed before.");
        } while (isprevious);

        if (number == targetNumber) throw new Exception();

        previousGuesses.Add(number);
    }
}
catch (Exception)
{
    Console.WriteLine("That was the bad number! You lose!");
}