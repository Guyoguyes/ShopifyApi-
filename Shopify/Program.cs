using Microsoft.EntityFrameworkCore;
using Shopify.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "host=127.0.0.1;Database=shopifydb;username=guyo;password=password";
var conString = "host=127.0.0.1;Database=shopifiedb;username=guyo;password=password";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShopifyContext>(options =>
    options.UseNpgsql(conString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();