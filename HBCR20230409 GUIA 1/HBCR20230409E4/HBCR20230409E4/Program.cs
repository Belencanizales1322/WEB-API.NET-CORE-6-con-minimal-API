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

var categorias = new List<Categorias>();

app.MapGet("/categorias", () =>
{
    return categorias;
});

app.MapPost("/categorias", (Categorias categoria) =>
{
    categorias.Add(categoria);
    return Results.Ok();
});

app.Run();

internal class Categorias
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string seccion { get; set; }

}