using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Shopify.Models;

namespace Shopify.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController: ControllerBase
{
    private readonly ShopifyContext _context;

    public CategoryController(ShopifyContext context)
    {
        _context = context;
        if (_context.category.Count() == 0)
        {
            _context.category.Add(new Category("Vegetables"));
            _context.SaveChanges();
        }
    }


    [HttpGet]
    public List<Category> getAll()
    {
        List<Category> allCategories = _context.category.ToList();
        return allCategories;
    }

    [HttpGet("id")]
    public Category getCatById(int id)
    {
        var catItem = _context.category.Find(id);
        return catItem;
    }

    [HttpPost]
    public Category postCatItem(Category category)
    {
        _context.category.Add(category);
        _context.SaveChanges();
        return category;
    }
}