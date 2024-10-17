public class Inventory
{
    public List<Item> Items = new();


    public void Display()
    {
        foreach(Item item in Items)
        {
            Console.WriteLine(item.Name);
        }
    }
}