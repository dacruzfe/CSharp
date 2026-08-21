using Exercicio_Cliente.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IClienteService, ClienteService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/clientes/{id}", (int id, IClienteService clienteService) =>
{
    var cliente = clienteService.ObterPorId(id);
    if (cliente is null)
       return Results.NotFound();

    var dto = new ClienteDto(cliente.Id, cliente.Nome, cliente.Email);
    
    return Results.Ok(dto);
});

app.MapGet("/clientes", (IClienteService clienteService) => 
{
    var clientesList = clienteService.ObterTodos();
    var dtos = clientesList.Select(c => new ClienteDto(c.Id, c.Nome, c.Email)).ToList();
    return Results.Ok(dtos);

});

app.MapPost("/clientes", (ClienteCreateDto novoCliente, IClienteService clienteService) =>
{
    var cliente = clienteService.Adicionar(novoCliente);
    var dto = new ClienteDto(cliente.Id, cliente.Nome, cliente.Email);
    return Results.Created($"/clientes/{dto.Id}", dto);
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
