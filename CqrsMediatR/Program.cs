using CqrsMediatR.Behaviors;
using CqrsMediatR.Domain;
using CqrsMediatR.FakeDataStore;
using MediatR;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddSingleton<Microsoft.Extensions.Logging.ILogger>(provider =>
   provider.GetRequiredService<Microsoft.Extensions.Logging.ILogger<Product>>());
// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddSingleton<FakeData>();
builder.Services.AddSingleton(typeof(IPipelineBehavior<,>) , typeof(LoggingBehavior<,>));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
