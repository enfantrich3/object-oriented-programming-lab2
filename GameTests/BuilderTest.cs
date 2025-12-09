using Xunit;
using GameInventory;

namespace GameTests
{
    public class BuilderTest
    {
        [Fact]
        public void WeaponBuilder_Test()
        {
            var w = new WeaponBuilder()
                .SetName("Топор")
                .SetDamage(40)
                .Build();

            Assert.NotNull(w);
            Assert.True(w.Damage > 0);
        }

        [Fact]
        public void ArmourBuilder_Test()
        {
            var a = new ArmourBuilder()
                .SetName("Шлем")
                .SetProtection(25)
                .Build();

            Assert.NotNull(a);
            Assert.True(a.Protection > 0);
        }
    }
}
