using Microsoft.EntityFrameworkCore;
using QuestionsApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Register controllers
builder.Services.AddEndpointsApiExplorer(); // Enable endpoint exploration
builder.Services.AddSwaggerGen(); // Add Swagger support

// Register ApplicationDbContext with the SQL Server provider (or adjust based on your DB)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Adjust connection string

// CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", builder =>
    {
        builder.WithOrigins("http://localhost:3001") // React app's URL
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("AllowReactApp");

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Serve Swagger UI
    app.UseSwaggerUI();
}

app.UseRouting(); // Ensure routing is enabled
app.UseAuthorization();

app.MapControllers(); // Map controller routes

app.Run();
