


using Microsoft.Extensions.Options;
using System.Web.Http;
var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.
builder.Services.Configure<MapApi.DB.IntegerSpiralDatabaseSettings>(builder.Configuration.GetSection(nameof(MapApi.DB.IntegerSpiralDatabaseSettings)));
builder.Services.AddSingleton<MapApi.DB.IIntegerSpiralDatabaseSettings>(sp=>sp.GetRequiredService<IOptions<MapApi.DB.IntegerSpiralDatabaseSettings>>().Value);
builder.Services.AddSingleton<MapApi.Services.Concreate.SpiralServices>();
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
