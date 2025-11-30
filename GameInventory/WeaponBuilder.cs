using GameInventory;

namespace GameInventory
{
    public class WeaponBuilder
    {
        private string name = "Неизвестное оружие";
        private int damage = 0;
        private string info = "Нет описания";

        public WeaponBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public WeaponBuilder SetDamage(int damage)
        {
            this.damage = damage;
            return this;
        }

        public WeaponBuilder SetInfo(string info)
        {
            this.info = info;
            return this;
        }

        public Weapon Build()
        {
            return new Weapon(name, damage, info)
            {
                Name = name,
                Info = info
            };
        }
    }
}
