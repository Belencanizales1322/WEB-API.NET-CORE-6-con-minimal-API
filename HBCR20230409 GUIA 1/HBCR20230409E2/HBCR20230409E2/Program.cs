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

var proveedores = new List<Proveedores>();

app.MapGet("/proveedores", () =>
{
return proveedores;
});



app.MapPost("/proveedores", (Proveedores provedor) =>
{
    proveedores.Add(provedor);
return Results.Ok();
});


app.MapDelete("/proveedores/{id}", (int id) =>
{
var existingProveedores = proveedores.FirstOrDefault(c => c.Id == id);
if (existingProveedores != null)
{
        proveedores.Remove(existingProveedores);
return Results.Ok();
}
else
{
return Results.NotFound(id);
}
});

app.Run();

internal class Proveedores
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Empresa{ get; set; }

}