using Cantracts;
using OnlineShop.Persistence.EF;
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
builder.Services.AddScoped<BassGuitarRepository,EFBassGuitarRepository>();
builder.Services.AddScoped<BassGuitarService,BassGuitarAppService>();
builder.Services.AddScoped<ElectriceGuitarRepository, EFElectricGuitarRepository>();
builder.Services.AddScoped<ElectricGuitarService,ElectricGuitarAppService>();
builder.Services.AddScoped<ClassicGuitarRepository, EFClassicGuitarRepository>();
builder.Services.AddScoped<ClassicGuitarService, ClassicGuitarAppService>();
builder.Services.AddScoped<AcousticGuitarRepository, EFAcousticGuitarRepository>();
builder.Services.AddScoped<AcousticGuitarService, AcousticGuitarAppService>();
builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<UserRepository, EFUserRepository>();
builder.Services.AddScoped<UserService,UserAppService>();



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
