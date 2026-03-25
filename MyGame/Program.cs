using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int enemyNum = Convert.ToInt32(args[0]);

            Enemy loki = new Enemy("Loki");


            Enemy[] enemies = new Enemy[enemyNum];

            for (int i = 0; i < enemyNum; i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string newName = Console.ReadLine();
                enemies[i] = new Enemy(newName);
            }

            foreach (Enemy bad in enemies)
            {
                Console.WriteLine($"{bad.GetName()} {bad.GetHealth()} {bad.GetShield()}");
            }

            loki.PickupPowerUp(PowerUp.Shield, 60);
            Console.WriteLine($"{loki.GetName()} {loki.GetHealth()} {loki.GetShield()}");

            loki.TakeDamage(70);
            Console.WriteLine($"{loki.GetName()} {loki.GetHealth()} {loki.GetShield()}");

            loki.PickupPowerUp(PowerUp.Health, 23);
            Console.WriteLine($"{loki.GetName()} {loki.GetHealth()} {loki.GetShield()}");

            Console.WriteLine($"This is how many pickups were used: {Enemy.TotalPowerupPickedUp()}");

        }
    }
}
