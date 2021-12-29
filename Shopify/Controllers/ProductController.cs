using Microsoft.AspNetCore.Mvc;
using Shopify.Models;

namespace Shopify.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController
{
    private ShopifyContext _context;

    public ProductController(ShopifyContext context)
    {
        _context = context;
    }

    [HttpPost]
    public Products AddProducts(Products product)
    {
         _context.products.Add(product);
        _context.SaveChanges();
        return product;
    }

    [HttpGet]
    public string getProduct()
    {
        return "Hello Products";
    }
}