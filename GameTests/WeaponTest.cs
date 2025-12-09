using Xunit;
using GameInventory;

namespace GameTests
{
    public class WeaponTest
    {
        [Fact]
        public void Weapon_Damage_Test()
        {
            var w = new Weapon("Меч", 20, "Тест");

            Assert.Equal(20, w.Damage);
        }

        [Fact]
        public void Weapon_Upgrade_Test()
        {
            var w = new Weapon("Меч", 10, "Тест");

            w.Upgrade();

            Assert.Equal(30, w.Damage);
        }

        [Fact]
        public void Weapon_Activate_Test()
        {
            var w = new Weapon("Меч", 5, "Тест");

            w.Activate();
        }
    }
}
