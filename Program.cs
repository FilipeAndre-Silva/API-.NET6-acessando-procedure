using EcommerceApi.Data;
using EcommerceApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>( options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Db"))
);

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

app.MapGet("/", (IProductService productService) => 
    {
        return productService.GetProProduct();
    }
);

app.Run();
