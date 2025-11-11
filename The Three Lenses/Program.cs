Console.Title = "The Three Lenses";

int[] input = new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };

foreach (int number in ProceduralCode(input))
    Console.Write($"{number} ");
Console.WriteLine();

foreach (int number in KeywordSyntax(input))
    Console.Write($"{number} ");
Console.WriteLine();

foreach (int number in MethodCallSyntax(input))
    Console.Write($"{number} ");
Console.WriteLine();

IEnumerable<int> ProceduralCode(int[] input)
{
    List<int> filtered = new List<int>();

    // Filter to only even numbers.
    foreach (int number in input)
        if (number % 2 == 0)
            filtered.Add(number);

    // Sorting the results.
    int[] results = filtered.ToArray();
    Array.Sort(results);

    // Doubling everything.
    for (int index = 0; index < results.Length; index++)
        results[index] *= 2;

    return results;
}

IEnumerable<int> KeywordSyntax(int[] input)
{
    return from n in input
           where n % 2 == 0
           orderby n
           select n * 2;
}

IEnumerable<int> MethodCallSyntax(int[] input)
{
    return input
        .Where(n => n % 2 == 0)
        .OrderBy(n => n)
        .Select(n => n * 2);
}

// Answer this question: Compare the size and understandability of these three approaches. Do any stand out as being particularly good or particularly bad?
//
//    The procedural code is the longest and least readable.
//    Query and method syntax are much shorter and clearer if you know delegates.
//    The keyword form is slightly shorter, but the readability gain is minimal.
//
// Answer this question: Of the three approaches, which is your personal favorite, and why?
//
//    Both query styles are clearly better than the procedural code,
//    which is longer and harder to read. If I had to choose,
//    I’d slightly prefer method syntax—mainly because I use it more often and it offers more flexibility,
//    even if that’s not evident here.








/*
1. What clause (keyword) starts a query expression?
from is the keyword that starts a query expression. It indicates where to pull data from.

2. What clause filters data?
where is the keyword/clause that determines which items to keep from a result set.

3. True/False. You can order by multiple criteria in a single orderby clause.
True. By separating the criteria with commas, you can name more than one thing to sort on.

4. What clause combines two related sets of data?
The join clause lets you evaluate items from multiple collections together.
*/