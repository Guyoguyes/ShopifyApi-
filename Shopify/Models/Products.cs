namespace Shopify.Models;

public class Products
{
    public int id { get; set; }
    public int catId { get; set; }
    public string name { get; set; }
    public int size { get; set; }
    public int price { get; set; }

    public Products(int catId, string name, int size, int price)
    {
        this.catId = catId;
        this.name = name;
        this.price = price;
    }
}