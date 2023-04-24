using Caching.Test.Interfaces;
using Caching.Test.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//For Distributed Cache
builder.Services.AddStackExchangeRedisCache(options => options.Configuration =builder.Configuration.GetConnectionString("Redis"));

//For In-Memory cache
builder.Services.AddMemoryCache();

builder.Services.AddSingleton<IDistributedCacheService, DistributedCache>();
builder.Services.AddSingleton<IInMemoryCacheService,InMemoryCache>();
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
