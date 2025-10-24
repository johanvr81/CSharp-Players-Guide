using Better_Random;

Console.Title = "Better Random";

Random random = new Random();

Console.WriteLine(random.NextDouble(100));
Console.WriteLine(random.NextString("Red", "Green", "Blue"));
Console.WriteLine(random.CoinFlip());
Console.WriteLine(random.CoinFlip(0.25));

