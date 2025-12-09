using Xunit;
using GameInventory;

namespace GameTests
{
    public class FactoryTest
    {
        [Fact]
        public void DefaultFactory_Test()
        {
            var factory = new DefaultItemFactory();

            var w = factory.CreateWeapon();
            var a = factory.CreateArmour();
            var e = factory.CreateElixir();

            Assert.NotNull(w);
            Assert.NotNull(a);
            Assert.NotNull(e);
        }

        [Fact]
        public void EpicFactory_Test()
        {
            var factory = new EpicItemFactory();

            var w = factory.CreateWeapon();

            Assert.True(w.Damage > 0);
        }
    }
}
