using GameInventory;
using Lab2;

class Program
{
    static void Main()
    {
        var inventory = new Inventory();

        var factory = new DefaultItemFactory();
        var manager = new InventoryManager(factory);

        Console.WriteLine("Вы собираете снаряжение для путешествия...");

        manager.AddWeaponToInventory(inventory);
        manager.AddArmourToInventory(inventory);
        manager.AddElixirToInventory(inventory);

        Console.WriteLine("Сумка путника содержит:");
        inventory.ShowInventory();

        Console.WriteLine("Вы пробуете воспользоваться оружием:");
        inventory.UseItem("Короткий клинок путника");

        Console.WriteLine("Путь ждёт впереди...");
    }
}
