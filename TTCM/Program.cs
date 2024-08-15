using Microsoft.EntityFrameworkCore;
using TTCM.Models;
using TTCM.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<QuanLyBanSachContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyDB")));


builder.Services.AddScoped<ISachRepository, Sach>();

builder.Services.AddScoped<ICategoryRepository, Category>();

builder.Services.AddScoped<INXBRepository, NXB>();

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
