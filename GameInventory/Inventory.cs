using Lab2;
namespace GameInventory
{
    public class Inventory
    {
        private readonly List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Артефакт «{item.Name}» помещён в хранилище.");
        }

        public void UseItem(string name)
        {
            Item item = GetItem(name);

            if (item is IUsable usable)
            {
                usable.Activate();
                items.Remove(item);
                Console.WriteLine($"Артефакт «{item.Name}» проявил свою силу и рассеялся.");
            }
            else
            {
                Console.WriteLine($"Артефакт «{item.Name}» лишён активных свойств.");
            }
        }

        public void Upgrade(string name)
        {
            Item item = GetItem(name);

            if (item is IUpgrade upgradeableItem)
            {
                upgradeableItem.Upgrade();
            }
            else
            {
                Console.WriteLine($"Артефакт «{item.Name}» не поддаётся улучшению.");
            }
        }

        public Item GetItem(string name)
        {
            return items.FirstOrDefault(i => i.Name == name)
                   ?? throw new InvalidOperationException("Артефакт с таким именем не найден.");
        }

        public void ShowInventory()
        {
            Console.WriteLine("Содержимое хранилища артефактов:");
            foreach (Item item in items)
            {
                Console.WriteLine($"• {item.Name} — {item.Info}");
            }
        }
    }
}

