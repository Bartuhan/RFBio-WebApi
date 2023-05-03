using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddApplicationPart(typeof(Presentation.AssemblyReferance).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration); // Services Extentions S�n�f�ndan Custom Y�klenen Service Extentions...
builder.Services.ConfigureRepositoryManager(); // Repository Manager S�n�f�n� IoC ye Tan�mlama ...
builder.Services.ConfigureServicesManager(); // Servis Manager S�n�f�n� IoC ye Tan�mlama ...


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
