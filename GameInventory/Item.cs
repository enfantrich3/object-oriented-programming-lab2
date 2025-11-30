namespace Lab2;

public abstract class Item
{
    public required string Name { get; set; }
    public required string Info { get; set; }

    protected Item(string name, string info)
    {
        Name = name;
        Info = info;
    }

    public abstract void Activate();
}
