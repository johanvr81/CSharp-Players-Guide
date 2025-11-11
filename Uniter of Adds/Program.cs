Console.Title = "Uniter of Adds";

Console.WriteLine(Add(1, 2));
Console.WriteLine(Add(1.1, 2.2));
Console.WriteLine(Add("abc", "def"));
Console.WriteLine(Add(DateTime.Now, TimeSpan.FromDays(1)));

dynamic Add(dynamic a, dynamic b) => a + b;

// Answer this question: What downside do you see with using dynamic here?
//
//    The main drawback is that the compiler can’t verify if a + operator exists for the given types,
//    so something like Add(DateTime.Now, 1) compiles but fails at runtime—one of the risks of dynamic typing.
