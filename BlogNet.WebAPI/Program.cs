using Microsoft.EntityFrameworkCore;
using BlogNet.Persistencia;

//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var mysqlversion = new MySqlServerVersion(new Version(8, 0, 31));
#nullable enable 
var contectionstring =builder.Configuration.GetConnectionString("ShopOnlineMySql");
builder.Services
 .AddDbContext<BlogNetContext>(options =>
    {
        
        options.UseMySql(contectionstring,ServerVersion.AutoDetect(contectionstring));
    });

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
