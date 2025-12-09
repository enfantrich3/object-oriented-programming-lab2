using Xunit;
using GameInventory;

namespace GameTests
{
    public class ElixirTest
    {
        [Fact]
        public void Elixir_Effect_Test()
        {
            var e = new Elixir("Эликсир", "Тест", "Сила +10");

            Assert.Equal("Сила +10", e.Effect);
        }

        [Fact]
        public void Elixir_Activate_Test()
        {
            var e = new Elixir("Эликсир", "Тест", "Сила +10");

            e.Activate();
        }
    }
}
