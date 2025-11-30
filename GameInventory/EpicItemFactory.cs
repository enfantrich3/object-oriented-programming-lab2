namespace GameInventory
{
    public class EpicItemFactory : IItemFactory
    {
        public Weapon CreateWeapon()
        {
            return new WeaponBuilder()
                .SetName("Меч странника")
                .SetDamage(90)
                .SetInfo("Большой меч, которым удобно сражаться с сильными противниками")
                .Build();
        }

        public Armour CreateArmour()
        {
            return new ArmourBuilder()
                .SetName("Железный доспех стража")
                .SetProtection(70)
                .SetInfo("Прочный доспех, обеспечивающий надёжную защиту в бою")
                .Build();
        }

        public Elixir CreateElixir()
        {
            return new ElixirBuilder()
                .SetName("Эликсир быстрого восстановления")
                .SetEffect("Восстанавливает 280 единиц здоровья")
                .SetInfo("Мощный эликсир для быстрой регенерации в критических ситуациях")
                .Build();
        }
    }
}

