using TibiaBazar.Application.Services;
using TibiaBazar.Application.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IScrapperService, ScrapperService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/test", (IScrapperService scrapper) =>
{
    var result = scrapper.Scrap();
    return "test";
})
.WithName("test")
.WithOpenApi();

app.Run();

