using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Transactions;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        private static int pickupNums;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                name = newName.Substring(0, 8);
            }

            else
            {
                name = newName;
            }

        }

        public void PickupPowerUp(PowerUp power, float hp)
        {
            if (power == PowerUp.Health)
            {
                if (health + hp >= 100)
                    health = 100;
                else
                    health += hp;
            }
            else if (power == PowerUp.Shield)
            {
                if (shield + hp >= 100)
                    shield = 100;
                else
                    shield += hp;
            }

            pickupNums++;
        }

        public static int TotalPowerupPickedUp()
        {
            
            return pickupNums;
        }
    }
}