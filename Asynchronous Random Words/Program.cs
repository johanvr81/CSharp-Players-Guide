Console.Title = "Asynchronous Random Words";


Console.Write("Enter a word to randomly regenerate: ");
string? word = Console.ReadLine();

DateTime start = DateTime.Now;
int attempts = await ChangeRandomlyeAsync(word);
Console.WriteLine(attempts);
TimeSpan elapsed = DateTime.Now - start;
Console.WriteLine(elapsed);

int ChangeRandomly(string? word)
{
    if (word == null) return 0;

    Random random = new Random();

    string generated;
    int attempts = 0;
    do
    {
        attempts++;
        generated = "";
        for (int letter = 0; letter < word.Length; letter++)
            generated += (char)('a' + random.Next(26));
    } while (generated != word);

    return attempts;
}

Task<int> ChangeRandomlyeAsync(string? word)
{
    return Task.Run(() => ChangeRandomly(word));
}



/*
Keyword for async work: async — required on any method using await.

Keyword to resume after task completion: await.

Common async return types: void, Task, Task<TResult> (also ValueTask, ValueTask<T>, IAsyncEnumerable<T>).

True/False: False — async isn’t always faster; thread overhead can slow things down. Use it only when performance gains justify the added complexity.

Best return types:

(a) Need completion but no result → Task

(b) Don’t care when it finishes → void

(c) Need a result → Task<T>
*/
