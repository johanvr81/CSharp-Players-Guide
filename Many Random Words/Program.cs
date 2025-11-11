Console.Title = "Many Random Words";


while (true)
{
    Console.Write("Enter a word to randomly regenerate: ");
    string? word = Console.ReadLine();
    TheWord(word);
}

async Task TheWord(string? word)
{
    DateTime start = DateTime.Now;
    int attempts = await ChangeRandomlyAsync(word);
    Console.WriteLine($"The word {word} took {attempts} attempts.");
    TimeSpan elapsed = DateTime.Now - start;
    Console.WriteLine(elapsed);
}

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

Task<int> ChangeRandomlyAsync(string? word)
{
    return Task.Run(() => ChangeRandomly(word));
}