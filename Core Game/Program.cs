using Core_Game;

Console.Title = "Core Game";

string name = ColoredConsole.Prompt("What is your name?").ToUpper();

Console.WriteLine("Game Mode Selection:");
Console.WriteLine("1 - Human vs. Computer");
Console.WriteLine("2 - Computer vs. Computer");
Console.WriteLine("3 - Human vs. Human");
string choice = ColoredConsole.Prompt("What mode do you want to use?");

IPlayer player1, player2;

if (choice == "1") { player1 = new ConsolePlayer(); player2 = new ComputerPlayer(); }
else if (choice == "2") { player1 = new ComputerPlayer(); player2 = new ComputerPlayer(); }
else { player1 = new ConsolePlayer(); player2 = new ConsolePlayer(); }

Party heroes = new Party(player1);
heroes.Characters.Add(new TheTrueProgrammer(name));
heroes.Items.Add(new HealthPotion());
heroes.Items.Add(new HealthPotion());
heroes.Items.Add(new HealthPotion());

List<Party> monsterParties = new List<Party> { CreateMonsterParty1(player2), CreateMonsterParty2(player2), CreateMonsterParty3(player2), CreateMonsterParty4(player2) };

for (int battleNumber = 0; battleNumber < monsterParties.Count; battleNumber++)
{

    Party monsters = monsterParties[battleNumber];
    Fight battle = new Fight(heroes, monsters);
    battle.Run();

    if (heroes.Characters.Count == 0) break;
}

if (heroes.Characters.Count > 0) ColoredConsole.WriteLine("You have defeated the Uncoded One's forces! You have won the battle!", ConsoleColor.Green);
else ColoredConsole.WriteLine("You have been defeated. The Uncoded One has won.", ConsoleColor.Red);


Party CreateMonsterParty1(IPlayer controllingPlayer)
{
    Party monsters = new Party(controllingPlayer);
    monsters.Characters.Add(new Skeleton { EquippedGear = new Dagger() });
    return monsters;
}

Party CreateMonsterParty2(IPlayer controllingPlayer)
{
    Party monsters = new Party(controllingPlayer);
    monsters.Characters.Add(new Skeleton());
    monsters.Characters.Add(new Skeleton());
    monsters.Gear.Add(new Dagger());
    monsters.Gear.Add(new Dagger());
    return monsters;
}

Party CreateMonsterParty3(IPlayer controllingPlayer)
{
    Party monsters = new Party(controllingPlayer);
    monsters.Characters.Add(new StoneAmarok());
    monsters.Characters.Add(new StoneAmarok());
    monsters.Items.Add(new HealthPotion());
    monsters.Items.Add(new HealthPotion());
    return monsters;
}

Party CreateMonsterParty4(IPlayer controllingPlayer)
{
    Party monsters = new Party(controllingPlayer);
    monsters.Characters.Add(new TheUncodedOne());
    return monsters;
}