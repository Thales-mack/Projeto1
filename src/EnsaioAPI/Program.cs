using EnsaioAPI.Context;
using EnsaioAPI.ViewModels;
using EnsaioAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EnsaioDbContext>(opt => opt.UseInMemoryDatabase("EnsaioDb"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureHttpJsonOptions(x =>
{
    x.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    x.SerializerOptions.ReferenceHandler = null;
});
builder.Services.AddCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("*");
app.UseStaticFiles();
app.UseDefaultFiles();

app.MapPost("/empresa", async (ClienteViewModel cliente, EnsaioDbContext context) =>
{
    context.Cliente.Add(new Cliente()
    {
       Nome = cliente.Nome,
       Cnpj = cliente.Cnpj,
    });

    await context.SaveChangesAsync();

    var result = await context.Cliente.FirstOrDefaultAsync(x => x.Cnpj == cliente.Cnpj);
    
    var response = new ClienteViewModelResponse()
    {
        Id = result!.Id,
        Cnpj = result.Cnpj,
        Nome = result.Nome
    };

    return Results.Ok(result);
})
.WithName("CriarCliente")
.WithOpenApi();


app.MapGet("/empresa/{id}", async (int id, EnsaioDbContext context) =>
{
    var cliente = await context.Cliente.FirstOrDefaultAsync(x => x.Id == id);
    if (cliente == null)
        return Results.NotFound();

    return Results.Ok(cliente);
})
.WithName("ObterCliente")
.WithOpenApi();

app.MapPost("empresa/ensaio", async (EnsaioViewModel ensaioViewModel, EnsaioDbContext context) =>
{
    var cliente = await context.Cliente.FirstOrDefaultAsync(x => x.Id == ensaioViewModel.ClientId);
    var ensaio = EnsaioViewModel.ToEnsaio(ensaioViewModel);
    ensaio.Cliente = cliente;
    context.Ensaio.Add(ensaio);
    await context.SaveChangesAsync();
    return Results.Ok(EnsaioViewModel.Map(ensaio));
});


app.MapGet("empresa/{id}/ensaio", async (int id, EnsaioDbContext context) =>
{
    var ensaios = context.Ensaio
        .Include(x => x.Cliente)
        .Include(x => x.Rotina)
        .Include(x => x.ResistenciaIsolamento)
        .Include(x => x.ResistenciaOhmicaEnrolamentos)
        .Where(x => x.Cliente.Id == id);

    List<EnsaioAPI.ViewModels.Ensaio> ensaiosList = new();
    foreach (var item in ensaios)
    {
        ensaiosList.Add(EnsaioViewModel.ToEnsaio(item));
    }
    return Results.Ok(ensaiosList);
})
.WithName("ObterEnsaios")
.WithOpenApi();

app.Run();
