using Lab2;

namespace GameInventory
{
    public class Elixir : Item, IUseable
    {
        public string Effect { get; set; }
        private bool isUsed = false;

        public Elixir(string name, string info, string effect)
                : base(name, info)
            {
                Effect = effect;
            }

        public void DisplayInfo()
        {
            string status = isUsed ? "[Опустошён]" : "[Запечатан]";
            Console.WriteLine($"{Name}: {Info} {status}. Волшебное свойство: {Effect}");
        }

        public override void Activate()
        {
            if (isUsed)
            {
                Console.WriteLine($"Эликсир {Name} уже был открыт ранее.");
                return;
            }

            isUsed = true;
            Console.WriteLine($"Вы открываете эликсир {Name} и пьёте его содержимое. {Effect}");
        }
    }
}
