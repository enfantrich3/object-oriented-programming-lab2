using Lab2;

namespace GameInventory
{
    public class Weapon : Item, IEquipable, IUseable, IUpgrade
    {
        public int Damage { get; set; }

        public Weapon(string name, int damage, string info) : base(name, info)
        {
            Damage = damage;
        }

        public void Wear()
        {
            Console.WriteLine($"{Name} вооружает героя.");
        }

            public void Use()
            {
                Console.WriteLine($"{Name} наносит удар, причиняя {Damage} урона.");
            }

        public void Upgrade()
        {
            Damage += 20;
            Console.WriteLine($"{Name} окрепло в вашей руке. Новый урон: {Damage}");
        }

        public override void Activate()
        {
            Use();
        }
    }
}
