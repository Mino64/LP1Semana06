using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            // CÓDIGO AQUI
            enemies.ToString();

        }

        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            int defHealth = defender.GetHealth();
            // Subtrai o Ataque do Atacante à Vida do Defensor
            // Garante que a Vida Não Fique Negativa
            // CÓDIGO AQUI
            if (defHealth - attacker.GetAttack() >= 0)
            {
                defender.SetHealth(defHealth - attacker.GetAttack());
            }
            else
            {
                defender.SetHealth(0);
            }


            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            // CÓDIGO AQUI
            if (defHealth == 0)
            {
                enemies.Remove(defender);
                Console.WriteLine($"{attacker} Wins!");

            }
        }
    }
}