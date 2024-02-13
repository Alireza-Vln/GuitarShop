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
builder.Services.AddScoped<BassGuitarRepostory,EFBassGuitarRepostory>();
builder.Services.AddScoped<BassGuitarService,BassGuitarAppService>();
builder.Services.AddScoped<ElectriceGuitarRepostory, EFElectricGuitarRepostry>();
builder.Services.AddScoped<ElectricGuitarService,ElectricGuitarAppService>();
builder.Services.AddScoped<ClassicGuitarRepostory, EFClassicGuitarRepostory>();
builder.Services.AddScoped<ClassicGuitarService, ClassicGuitarAppService>();
builder.Services.AddScoped<AcousticGuitarRepostory, EFAcousticGuitarRepostory>();
builder.Services.AddScoped<AcousticGuitarService, AcousticGuitarAppService>();
builder.Services.AddScoped<UserRepostory, EFUserRepostory>();
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
