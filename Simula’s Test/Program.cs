// See https://aka.ms/new-console-template for more information
Console.Title = "Simula’s Test";

ChestState boxSate = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {boxSate}. What do you want to do? ");

    string action = Console.ReadLine();

    if (boxSate == ChestState.Locked && action == "unlock") boxSate = ChestState.Closed;
    if (boxSate == ChestState.Closed && action == "open") boxSate = ChestState.Open;
    if (boxSate == ChestState.Open && action == "close") boxSate = ChestState.Closed;
    if (boxSate == ChestState.Closed && action == "lock") boxSate = ChestState.Locked;
}
enum ChestState
{
    Open,
    Closed,
    Locked
}
