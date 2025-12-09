using Lab2;
namespace GameInventory;

public class Armour : Item, IEquipable, IUsable
{
    public int Protection { get; set; }

    public Armour(string name, int protection, string info) 
        : base(name, info)
    {
        Protection = protection;
    }

    public void Wear()
    {
        System.Console.WriteLine($"Вы облачили {Name}. Теперь она дарует {Protection} единиц защиты от магических и физических ударов.");
    }

    public void Use()
    {
        System.Console.WriteLine($"{Name} излучает ауру защиты, обеспечивая {Protection} очков защиты.");
    }

    public override void Activate()
    {
        Use();
    }
}
