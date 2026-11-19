using Scalar.AspNetCore;

// REGISTRACE SLUŽEB = DEPENDENCY INJECTION KONTEJNER
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); // najde všechny kontrolery
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(); // vygeneruje popis API

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // pokud běží jen v developmentu
{
    app.MapOpenApi(); // /openapi/v1.json
    app.MapScalarApiReference();
}

app.UseHttpsRedirection(); // http -> https

app.UseAuthorization(); // zatím nic nedělá

app.MapControllers(); // URL -> pošle to správné metodě kontroleru

// middleware - požadavek od uživatele -> stanoviště (upravit, zkontrolovat, zahodit, poslat dál) -> stanoviště -> controller (sprváná metoda) ==>  vrátí výsledek

app.Run(); // běž a čekej na požadavky
