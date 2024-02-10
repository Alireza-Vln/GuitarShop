using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services;
using OnlineShopGuitar.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EfDbContext>();
builder.Services.AddScoped<IBassGuitarService,BassGuitarService>();
builder.Services.AddScoped<IBassGuitarRepostory,BassGuitarRepostory>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserRepostory, UserRepostory>();
builder.Services.AddScoped<IElectriceGuitarRepostory, ElectricGuitarRepostry>();
builder.Services.AddScoped<IElectricGuitarService,ElectricGuitarService>();
builder.Services.AddScoped<IClassicGuitarRepostory, ClassicGuitarRepostory>();
builder.Services.AddScoped<IClassicGuitarService, ClassicGuitarService>();
builder.Services.AddScoped<IAcousticGuitarRepostory, AcousticGuitarRepostory>();
builder.Services.AddScoped<IAcousticGuitarService, AcousticGuitarService>();



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
