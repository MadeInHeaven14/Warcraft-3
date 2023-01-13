using Warcraft_3;

Mage mage = new Mage();
Peasant peasant = new Peasant();
Footman footman = new Footman();
Archer archer = new Archer();
BlackSmith blacksmith = new BlackSmith();

archer.Attack(peasant);
archer.Attack(peasant);
archer.Attack(peasant);
mage.TargetHeal(peasant);
footman.Attack(archer);
footman.Attack(archer);
footman.Attack(archer);
footman.Attack(archer);
footman.Attack(archer);
footman.Attack(archer);
mage.TargetHeal(archer); 