namespace Shopify.Models;

public class Category
{
    public int id { get; set; }
    public string name { get; set; }

    public Category(string name)
    {
        this.name = name;
    }
}