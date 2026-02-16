var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Testing GitHub Copilot. This is a test comment

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
