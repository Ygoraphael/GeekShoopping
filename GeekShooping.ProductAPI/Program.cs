using GeekShooping.ProductAPI.Startup;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterServices(builder.Configuration);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.Run();
