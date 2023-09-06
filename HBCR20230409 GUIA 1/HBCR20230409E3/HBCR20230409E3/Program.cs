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

var marcas = new List<Marcas>();

app.MapGet("/marcas", () =>
{
return marcas;
});

app.MapGet("/marcas/(id)", (int id) =>
{
    var client = marcas.FirstOrDefault(c => c.Id == id);
    return client;
});

app.MapPost("/marcas", (Marcas marca) =>
{
    marcas.Add(marca);
return Results.Ok();
});


app.MapPut("/ marcas /{ id}", (int id, Marcas marca) =>
{
    var existingMarcas = marcas.FirstOrDefault(c => c.Id == id);
    if (existingMarcas != null)
    {
        existingMarcas.Name = marca.Name;
        existingMarcas.Proveedor = marca.Proveedor;
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

app.Run();

internal class Marcas
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Proveedor { get; set; }

}