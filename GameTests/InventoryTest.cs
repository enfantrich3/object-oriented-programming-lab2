using Xunit;
using GameInventory;

namespace GameTests
{
    public class InventoryTest
    {
        [Fact]
        public void AddItem_Test()
        {
            var inv = new Inventory();
            var weapon = new Weapon("Меч", 10, "Тест");

            inv.AddItem(weapon);

            Assert.NotNull(inv.GetItem("Меч"));
        }

        [Fact]
        public void UseItem_Test()
        {
            var inv = new Inventory();
            var elixir = new Elixir("Эликсир", "Тест", "Хил");

            inv.AddItem(elixir);
            inv.UseItem("Эликсир");

        }

        [Fact]
        public void Upgrade_Test()
        {
            var inv = new Inventory();
            var weapon = new Weapon("Меч", 10, "Тест");

            inv.AddItem(weapon);
            inv.Upgrade("Меч");

            Assert.True(weapon.Damage > 10);
        }
    }
}
