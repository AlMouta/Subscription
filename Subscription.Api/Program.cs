using Subscription.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//Injeção de dependências
builder.Services.AddInfraStructure(builder.Configuration);

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
