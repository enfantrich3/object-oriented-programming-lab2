using Lab2;

namespace GameInventory
{
    public class DefaultItemFactory : IItemFactory
    {
        public Weapon CreateWeapon()
        {
            return new WeaponBuilder()
                .SetName("Короткий клинок путника")
                .SetDamage(25)
                .SetInfo("Небольшой клинок, удобный для путешествий и самообороны")
                .Build();
        }

        public Armour CreateArmour()
        {
            return new ArmourBuilder()
                .SetName("Кожаный жилет стража")
                .SetProtection(15)
                .SetInfo("Простой кожаный жилет, обеспечивает базовую защиту")
                .Build();
        }

        public Elixir CreateElixir()
        {
            return new ElixirBuilder()
                .SetName("Эликсир силы")
                .SetEffect("Временно повышает силу на 30 единиц")
                .SetInfo("Слабый эликсир, помогающий в коротких схватках")
                .Build();
        }
    }
}
