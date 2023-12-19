using Solid.Core.Repositories;
using Solid.Core.service;
using Solid.data;
using Solid.Data;
using Solid.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRecreationService, RecreationService>();
builder.Services.AddScoped<ISaleAndRentingService, SaleAndRentingService>();
builder.Services.AddScoped<ICustomersService, CustomersService>();
builder.Services.AddScoped<IRecreationRepository, RecreationRepository>();
builder.Services.AddScoped<ISaleAndRentingRepository, SaleAndRentingRepository>();
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
builder.Services.AddSingleton<DataContext>();
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
