using Application;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices();

builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddHttpContextAccessor();

//builder.Services.AddDistributedMemoryCache(); //yayın ortamında redis kullanılabilir
builder.Services.AddStackExchangeRedisCache(opt=>opt.Configuration="localhost:6379"); //solid prensiplerine uygun bir şekilde redis cache eklendi

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
//if(app.Environment.IsProduction()) //görülen hatanın sebebini görmek için arada açıp bakabilirsin
app.ConfigureCustomExceptionMiddleware(); //Global exception handler, hata yönetimi

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();