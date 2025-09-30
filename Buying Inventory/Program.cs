// See https://aka.ms/new-console-template for more information
Console.Title = "Buying Inventory / Discounted Inventory";

Console.Write("The following items are available:" +
    "\r\n1 – Rope" +
    "\r\n2 – Torches" +
    "\r\n3 – Climbing Equipment" +
    "\r\n4 – Clean Water" +
    "\r\n5 – Machete" +
    "\r\n6 – Canoe" +
    "\r\n7 – Food Supplies" +
    "\n");

Console.WriteLine("What number do you want to see the price of?");
int item = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your name?");
string customer = Console.ReadLine();

string itemdetail;

itemdetail = item switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Machete",
    7 => "Machete",
    _ => "No item"
};

int price = itemdetail switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
    "No item" => 0
};

if (customer == "Johan") price /= 2;

Console.WriteLine($"{itemdetail} costs {price} gold.");
