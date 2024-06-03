using StudentAPI.Infrastructure.DbContext;
using StudentAPI.Infrastructure;
using StudentAPI.Application;
using StudentAPI;

var builder = WebApplication.CreateBuilder(args);


var configuration = new ConfigurationManager();
builder.Services.AddInfrastructure(configuration);
builder.Services.AddApplication();
builder.Services.AddPresentation();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddInfrastructure(builder.Configuration);


var app = builder.Build();

//var dapperContext = app.Services.GetRequiredService<DapperContext>();
//bool isConnected = dapperContext.IsConnectionEstablished();
//if (isConnected)
//{
//    System.Console.WriteLine("Database connection is established.");
//}
//else
//{
//    System.Console.WriteLine("Failed to establish database connection.");
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
