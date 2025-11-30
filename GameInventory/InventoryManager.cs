using GameInventory;
using Lab2;

namespace Lab2
{
    public class InventoryManager
    {
        private readonly IItemFactory itemFactory;

        public InventoryManager(IItemFactory factory)
        {
            itemFactory = factory;
        }

        public void AddWeaponToInventory(Inventory inventory)
        {
            Weapon weapon = itemFactory.CreateWeapon();
            inventory.AddItem(weapon);
        }

        public void AddArmourToInventory(Inventory inventory)
        {
            Armour armour = itemFactory.CreateArmour();
            inventory.AddItem(armour);
        }

        public void AddElixirToInventory(Inventory inventory)
        {
            Elixir elixir = itemFactory.CreateElixir();
            inventory.AddItem(elixir);
        }
    }
}

