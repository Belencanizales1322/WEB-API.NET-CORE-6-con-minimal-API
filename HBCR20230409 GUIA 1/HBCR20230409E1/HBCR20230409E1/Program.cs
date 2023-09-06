var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var product = new List<Productos>();

app.MapGet("/product", () =>
{
return product;
});

app.MapGet("/product/(id)", (int id) =>
{
var client = product.FirstOrDefault(c => c.Id == id);
return client;
});

app.MapPost("/product", (Productos products) =>
{
product.Add(products);
return Results.Ok();
});

app.MapPut("/ product /{ id}", (int id, Productos products) =>
{
var existingProductos = product.FirstOrDefault(c => c.Id == id);
if (existingProductos != null)
{
        existingProductos.Name = products.Name;
        existingProductos.Description = products.Description;
return Results.Ok();
}
else
{
return Results.NotFound();
}
});

app.MapDelete("/product/{id}", (int id) =>
{
var existingProductos = product.FirstOrDefault(c => c.Id == id);
if (existingProductos != null)
{
product.Remove(existingProductos);
return Results.Ok();
}
else
{
return Results.NotFound(id);
}
});

app.Run();

internal class Productos
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description{ get; set; }

}