using Packing_Inventory;

Console.Title = "Labeling Inventory";

Pack pack = new Pack(10, 20, 30);

while (true)
{
    Console.WriteLine(pack);
    Console.WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");

    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    int choice = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = choice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };

    if (!pack.Add(newItem))
        Console.WriteLine("Could not add this to the pack.");
}

// Question: Instead of overriding `ToString`, we could have created a separate method or 
// property (e.g., `Description`). Which approach is better, and why?
//
// There’s no single correct answer here—it depends on context. Both approaches have their place. 
// One thing to keep in mind is that `ToString` is used frequently throughout .NET. 
// If an object doesn’t have one clear, definitive string representation, it may be better 
// to create a dedicated property or method instead.
//
// The advantage of overriding `ToString` is convenience: for example, 
// `Console.WriteLine(new Sword());` will automatically display the string representation. 
// If we used a `Description` property instead, we’d need to call 
// `Console.WriteLine(new Sword().Description);` explicitly.
//
// In this particular case, overriding `ToString` keeps the code simpler and avoids 
// introducing extra properties. However, if the class needed multiple textual representations 
// (such as both a title and a detailed description), then defining separate `Title` 
// and `Description` properties would be the better choice.