namespace Scuffed_ZORK
{
    class Weapon : Item
    {
        public int damage;
        public int nrgCost;
        public Weapon(string _itemName, int dmg, int nrg) : base(_itemName, "Smells like danger.", "Sounds like it could deal some damage.", "You're lucky that didn't hurt you.", $"This weapon costs {nrg} energy to deal {dmg} damage.")
        {
            damage = dmg;
            nrgCost = nrg;
        }
    }
}
