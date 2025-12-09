using Xunit;
using GameInventory;
using Lab2;

namespace GameTests
{
    public class InventoryManagerTests
    {
        [Fact]
        public void AddWeapon_Test()
        {
            var factory = new DefaultItemFactory();
            var manager = new InventoryManager(factory);
            var inv = new Inventory();

            manager.AddWeaponToInventory(inv);

            Assert.NotNull(inv);
        }

        [Fact]
        public void AddArmour_Test()
        {
            var factory = new DefaultItemFactory();
            var manager = new InventoryManager(factory);
            var inv = new Inventory();

            manager.AddArmourToInventory(inv);

            Assert.NotNull(inv);
        }

        [Fact]
        public void AddElixir_Test()
        {
            var factory = new DefaultItemFactory();
            var manager = new InventoryManager(factory);
            var inv = new Inventory();

            manager.AddElixirToInventory(inv);

            Assert.NotNull(inv);
        }
    }
}
