using PrimeiraAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("AppDbConnectionString"); //Procura no arquivo appsettings.json dentro da seção "ConnectionStrings" e pega oque esta dentro de "AppDbConnectionString"
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString)); //Diz ao Entity Framework para usar o PostgreSQL usando essa connection string

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); //utilização do swagger 
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
