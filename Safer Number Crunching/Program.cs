Console.Title = "Safer Number Crunching";

int firstnumber;

do
{
    Console.Write("Enter an integer: ");
} while (!int.TryParse(Console.ReadLine(), out firstnumber));
Console.WriteLine(firstnumber);

double secondnumber;

do
{
    Console.Write("Enter a number: ");
} while (!double.TryParse(Console.ReadLine(), out secondnumber));
Console.WriteLine(secondnumber);

bool truthValue;

do
{
    Console.Write("Enter true or false: ");
} while (!bool.TryParse(Console.ReadLine(), out truthValue));
Console.WriteLine(truthValue);


/*
 
1. True/False. Events allow one object to notify another object when something occurs.
True. This is the intended purpose of events.

2. True/False. Any method can be attached to a specific event.
False. The parameter types and return type must be identical; the method’s name and body are irrelevant.

3. True/False. Once attached to an event, a method cannot be detached from an event.
False. You can and should unsubscribe an event handler when done, to prevent memory leaks.

*/