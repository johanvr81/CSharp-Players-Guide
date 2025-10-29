using Charberry_Trees;

Console.Title = "Charberry Trees";

CharberryTree tree = new CharberryTree();

Notifier announcer = new Notifier(tree);
Harvester harvester = new Harvester(tree);

while (true)
tree.MaybeGrow();









