using System;

namespace Scuffed_ZORK
{
    class Food : Item
    {
        public int energyIncrease = 0;
        public int healthIncrease = 0;
        public int maxHealthIncrease = 0;
        // Normal Food Constructor
        public Food(string _itemName, string tasteText, int nrg, int hp) : base(_itemName, "Strange, it doesn't smell of anything.", "Sounds like food to me.", tasteText, $"Eating this increases energy by {nrg} and health by {hp}.")
        {
            energyIncrease = nrg;
            healthIncrease = hp;
        }
        // Max Health Food Constructor
        public Food(string _itemName, string tasteText, int maxHealth) : base(_itemName, "Smells Magical!", "Sounds like food to me.", tasteText, $"Eating this increases maximum health by {maxHealth}")
        {
            itemName = _itemName;
            maxHealthIncrease = maxHealth;
        }
        public void Eat(Enemy enemy)
        {
            if (enemy != null)
            {
                enemy.energy += energyIncrease;
                if (enemy.health >= enemy.maxHealth - healthIncrease)
                {
                    enemy.health = enemy.maxHealth;
                } else
                {
                    enemy.health += healthIncrease;
                }
                enemy.loot.Remove(this);
                if (itemName.ToLower()[0] == 'a' || itemName.ToLower()[0] == 'e' || itemName.ToLower()[0] == 'i' || itemName.ToLower()[0] == 'o' || itemName.ToLower()[0] == 'u')
                {
                    Console.WriteLine($"{enemy.name} has eaten an {itemName}. They gained {energyIncrease} energy and {healthIncrease} hp.");
                } else
                {
                    Console.WriteLine($"{enemy.name} has eaten a {itemName}. They gained {energyIncrease} energy and {healthIncrease} hp.");
                }
                return;
            } // At this point, it is the player that is eating the food
            if (maxHealthIncrease != 0) // If the food is a Max Health Food
            {
                Program.maxPlayerHealth += maxHealthIncrease;
                Console.WriteLine($"You have eaten a {itemName}. You gained {maxHealthIncrease} maximum health.");
                return;
            }
            if (healthIncrease > 0 && Program.playerHealth == Program.maxPlayerHealth) // If the food will heal the player and the player is at max health
            {
                Console.WriteLine("You are not hungry at the moment.");
                return;
            }
            Program.playerEnergy += energyIncrease;
            if (Program.playerHealth >= Program.maxPlayerHealth - healthIncrease)
            {
                Program.playerHealth = Program.maxPlayerHealth;
            } else
            {
                Program.playerHealth += healthIncrease;
            }
            Program.inventory.Remove(this);
            if (itemName.ToLower()[0] == 'a' || itemName.ToLower()[0] == 'e' || itemName.ToLower()[0] == 'i' || itemName.ToLower()[0] == 'o' || itemName.ToLower()[0] == 'u')
            {
                Console.WriteLine($"You have eaten an {itemName}. You gained {energyIncrease} energy and {healthIncrease} hp.");
            }
            else
            {
                Console.WriteLine($"You have eaten a {itemName}. You gained {energyIncrease} energy and {healthIncrease} hp.");
            }
        }
    }
}
