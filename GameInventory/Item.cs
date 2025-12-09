namespace Lab2;

public abstract class Item
{
    public string Name { get; set; }
    public string Info { get; set; }

    protected Item(string name, string info)
    {
        Name = name;
        Info = info;
    }

    public abstract void Activate();
}

