

using Lambda_Sieve;

Console.Title = "Lambda Sieve";


Console.Write("Which filter do you want to use? (1=Even, 2=Positive, 3=MultipleOfTen) ");
int choice = Convert.ToInt32(Console.ReadLine());

Sieve sieve = choice switch
{
1 => new Sieve(n => n % 2 == 0),
2 => new Sieve(n => n > 0),
3 => new Sieve(n => n % 10 == 0)
};

while (true)
{
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

string goodOrEvil = sieve.IsGood(number) ? "good" : "evil";
Console.WriteLine($"That number is {goodOrEvil}.");
}

// Answer this question: Does this change make the program shorter or longer?
//
//    The program got _slightly_ shorter. I think I removed 3 lines of code and maybe a blank line.
//
// Answer this question: Does this change make the program easier or harder to read?
//
//  I expected it to make the code both shorter and clearer, but it only slightly reduced the length, and readability didn’t really improve. For example, 2 => new Sieve(n => n > 0) isn’t very clear without checking what 2 means. Using something like "even" instead would help.
//
//  Overall, readability should always come first—lambdas can help, but not always, so it’s important to weigh the trade-offs in each case.
