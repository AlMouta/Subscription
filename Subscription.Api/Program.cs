using Scalar.AspNetCore;
using Subscription.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddRouting(map => map.LowercaseUrls = true);    

builder.Services.AddEndpointsApiExplorer(); //Swagger
builder.Services.AddSwaggerGen(); //Swagger


//Injeção de dependências
builder.Services.AddInfraStructure(builder.Configuration);

var app = builder.Build();

app.UseSwagger(); //Swagger
app.UseSwaggerUI(); //Swagger

app.MapScalarApiReference(options => options.WithTheme(ScalarTheme.BluePlanet)); //Scalar

app.MapOpenApi();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
