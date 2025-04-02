using Sistema_de_Batalha_de_Turno;

Unit player = new Unit(100, 20, 12, "Jogador");
Unit enemy = new Unit(75, 10, 7, "Mago do Mal");
Random random = new Random();

while (!player.isDead && !enemy.isDead)
{
    Console.WriteLine(player.UnitName + " HP = " + player.HP + ". " + enemy.UnitName + " HP = " + enemy.HP);
    Console.WriteLine("Turno do jogador! O que você irá fazer? Ataque com 'a' e se cure com 'h'");
    string choice = Console.ReadLine().ToLower();

    if (choice == "a")
    {
        player.Attack(enemy);
    }
    else if (choice == "h")
    {
        player.Heal();
    }
    else
    {
        Console.WriteLine("Digite uma tecla válida!");
    }

    if (player.isDead || enemy.isDead) break;

    Console.WriteLine(player.UnitName + " HP = " + player.HP + ". " + enemy.UnitName + " HP = " + enemy.HP);

    Console.WriteLine("Turno do inimigo!");

    int rand = random.Next(0, 2);

    if (rand == 0)
        enemy.Attack(player);
    else
    {
        enemy.Heal();
    }
}

