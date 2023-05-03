using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddApplicationPart(typeof(Presentation.AssemblyReferance).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration); // Services Extentions Sýnýfýndan Custom Yüklenen Service Extentions...
builder.Services.ConfigureRepositoryManager(); // Repository Manager Sýnýfýný IoC ye Tanýmlama ...
builder.Services.ConfigureServicesManager(); // Servis Manager Sýnýfýný IoC ye Tanýmlama ...


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
