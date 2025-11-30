using GameInventory;

namespace GameInventory
{
    public interface IItemFactory
    {
        Weapon CreateWeapon();
        Armour CreateArmour();
        Elixir CreateElixir();
    }
}
