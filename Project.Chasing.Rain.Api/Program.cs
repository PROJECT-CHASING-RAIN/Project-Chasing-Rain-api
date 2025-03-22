using Project.Chasing.Rain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure the database context.
builder.Services.AddDbContext<StoreContext>(options =>
{
    options.UseSqlite("Data Source = ../Registrar.sqlite",
        b => b.MigrationsAssembly("Project.Chasing.Rain.Api"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

// Add Swagger/OpenAPI services.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Already present, no changes needed.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Replace MapOpenApi with UseSwagger
    app.UseSwaggerUI(); // Add Swagger UI for development
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();