namespace Shopify.Models;

public class Customer
{
    public int id { get; set; }
    public string fullName { get; set;}
    public string phone { get; set; }
    public string address {get; set;}
    
    //constructor
    public Customer(string fullName, string phone, string address)
    {
        this.fullName = fullName;
        this.phone = phone;
        this.address = address;
    }
}