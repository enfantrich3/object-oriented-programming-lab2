using Xunit;
using GameInventory;

namespace GameTests
{
    public class ArmourTest
    {
        [Fact]
        public void Armour_Protection_Test()
        {
            var a = new Armour("Броня", 15, "Тест");

            Assert.Equal(15, a.Protection);
        }

        [Fact]
        public void Armour_Activate_Test()
        {
            var a = new Armour("Броня", 10, "Тест");

            a.Activate();
        }
    }
}
