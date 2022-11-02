using System.Collections.Generic;

namespace Scuffed_ZORK
{
    class Enemy
    {
        public string name;
        public int health;
        public int maxHealth;
        public int damage;
        public int energy;
        public string examineText;
        public Square square;
        public bool isWaiting = false;
        public List<Item> loot = new List<Item>();
        public Enemy(Square _square, string enemyName, int _maxHealth, int difference, int atkDmg, params Item[] lootDrops)
        {
            name = enemyName;
            square = _square;
            maxHealth = _maxHealth;
            health = maxHealth - difference;
            damage = atkDmg;
            energy = Program.RNG(2, 5);
            examineText = $"{name} has a maximum of {maxHealth} hp, an attack damage of {damage}, and smells quite bad.";
            loot.InsertRange(0, lootDrops);
        }
    }
}
