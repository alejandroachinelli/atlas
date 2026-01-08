using Atlas.Modules.Identity.Persistence;
using Atlas.Modules.Identity.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("AtlasDb");

builder.Services.AddDbContext<IdentityDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();